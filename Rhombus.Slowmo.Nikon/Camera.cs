using System.Diagnostics.CodeAnalysis;

namespace Rhombus.Slowmo.Nikon;
using global::Nikon;

public class Camera {
    private readonly NikonDevice _device;


    public Camera(NikonDevice device) {
        _device = device;
        _device.LiveViewEnabled = true;
    }

    public Task<IEnumerable<NikonImage>> Capture() {
        var tcs = new TaskCompletionSource<IEnumerable<NikonImage>>();
        var images = new System.Collections.Concurrent.ConcurrentBag<NikonImage>();



        _device.ImageReady += ImageReady;
        _device.CaptureComplete += CaptureComplete;

        Task.Run(_device.Capture);
        return tcs.Task;

        void CaptureComplete(NikonDevice sender, int data) {
            _device.CaptureComplete -= CaptureComplete;
            _device.ImageReady -= ImageReady;
            tcs.SetResult(images);
        }
        void ImageReady(NikonDevice sender, NikonImage image) => images.Add(image);
    }

    /// <summary>
    /// This will select the sensitivity of camera (Shooting menu)
    /// </summary>
    public Iso Iso {
        get => GetEnum<Iso>(eNkMAIDCapability.kNkMAIDCapability_Sensitivity);
        set => SetEnum(eNkMAIDCapability.kNkMAIDCapability_Sensitivity, value);
    }

    public bool IsoControl {
        get => _device.GetBoolean(eNkMAIDCapability.kNkMAIDCapability_IsoControl);
        set => _device.SetBoolean(eNkMAIDCapability.kNkMAIDCapability_IsoControl, value);
    }

    public NoiseReductionHighIso NoiseReductionHighIso {
        get => (NoiseReductionHighIso)_device.GetUnsigned(eNkMAIDCapability.kNkMAIDCapability_NoiseReductionHighISO);
        set => _device.SetUnsigned(eNkMAIDCapability.kNkMAIDCapability_NoiseReductionHighISO, (uint)value);
    }
    /// <summary>  This will set the shutter speed when ISO is controlled automatically (Shooting Menu)  </summary>
    /// <remarks>When the ExposureMode is Scene Modes or Special Effects Modes or during movie recording or the IsoControl is False this capability cannot be set</remarks>
    public IsoAutoShutterTime IsoAutoShutterTime {
        get => (IsoAutoShutterTime)_device.GetUnsigned(eNkMAIDCapability.kNkMAIDCapability_ISOAutoShutterTime);
        set => _device.SetUnsigned(eNkMAIDCapability.kNkMAIDCapability_ISOAutoShutterTime, (uint)value);
    }
    public uint ContinuousShootingNum {
        get => _device.GetUnsigned(eNkMAIDCapability.kNkMAIDCapability_ContinuousShootingNum);
        set => _device.SetUnsigned(eNkMAIDCapability.kNkMAIDCapability_ContinuousShootingNum, value);
    }
    

    public CompressionLevel CompressionLevel {
        get => GetEnum<CompressionLevel>(eNkMAIDCapability.kNkMAIDCapability_CompressionLevel);
        set => SetEnum(eNkMAIDCapability.kNkMAIDCapability_CompressionLevel, value);
    }


    public AEBracketingStep AeBracketingStep {
        get {
            var step = _device.GetEnum(eNkMAIDCapability.kNkMAIDCapability_AEBracketingStep);
            return step.AsEnumerable()
                       .Select((p, index) => (value: (AEBracketingStep)p, index))
                       .Where(p => p.index == step.Index)
                       .Select(p => p.value)
                       .Single();
        }
        set {
            var step = _device.GetEnum(eNkMAIDCapability.kNkMAIDCapability_AEBracketingStep);
            var result = step.AsEnumerable()
                             .Select((p, index) => (value:(AEBracketingStep)p, index))
                             .Where(p => p.value == value)
                             .Select(p => p.index)
                             .Cast<int?>()
                             .SingleOrDefault();


            step.Index = result ?? throw new ArgumentOutOfRangeException(nameof(value));
        }
    }


    public ShootingMode ShootingMode {
        get => GetEnum<ShootingMode>(eNkMAIDCapability.kNkMAIDCapability_ShootingMode);
        set => SetEnum(eNkMAIDCapability.kNkMAIDCapability_ShootingMode, value);
    }
    //public ShootingMode ShootingMode {
    //    get => (ShootingMode)_device.GetUnsigned(eNkMAIDCapability.kNkMAIDCapability_ShootingMode);
    //    set => _device.SetUnsigned(eNkMAIDCapability.kNkMAIDCapability_ShootingMode, (uint)value);
    //}
    public SaveMedia SaveMedia {
        get => (SaveMedia)_device.GetUnsigned(eNkMAIDCapability.kNkMAIDCapability_SaveMedia);
        set => _device.SetUnsigned(eNkMAIDCapability.kNkMAIDCapability_SaveMedia, (uint)value);
    }

    public bool BracketingEnabled {
        get => _device.GetBoolean(eNkMAIDCapability.kNkMAIDCapability_EnableBracketing);
        set => _device.SetBoolean(eNkMAIDCapability.kNkMAIDCapability_EnableBracketing, value);
    }

    public uint FocusStep {
        get => (uint)GetRange(eNkMAIDCapability.kNkMAIDCapability_MFDriveStep);
        set => SetRange(eNkMAIDCapability.kNkMAIDCapability_MFDriveStep, value);
    }

    public  Task Focus(int step) {
        this.FocusStep = (uint)(step == int.MinValue ? int.MaxValue : Math.Abs(step)); // can't call Math.Abs on int.MinValue
        var direction = step               > 0 ? DriveDirection.ClosestToInfinity : DriveDirection.InfinityToClosest;
        _device.SetUnsigned(eNkMAIDCapability.kNkMAIDCapability_MFDrive, (uint)direction);
        return Task.Delay(1000);
        //while (true) {
        //    var nikonArray = _device.GetArray(eNkMAIDCapability.kNkMAIDCapability_GetLiveViewImage);
        //    var liveViewImageData = nikonArray.Buffer.As<LiveViewImageData>();
        //    //var imageData = a.Buffer.AsSpan(384);
        //    if (!liveViewImageData.FocusDriving) {
        //        return;
        //    }

        //    await Task.Yield();
        //}
    }
    private T GetEnum<T>(eNkMAIDCapability capability) where T : struct {
        var nikonEnum = _device.GetEnum(capability);
        return (T)(object)nikonEnum.Index;
    }

    private void SetEnum<T>(eNkMAIDCapability capability, T value) where T : struct {
        var nikonEnum = _device.GetEnum(capability);
        nikonEnum.Index = (int)(uint)(object)value;
        _device.SetEnum(capability, nikonEnum);
    }
    private double GetRange(eNkMAIDCapability capability) {
        var nikonRange = _device.GetRange(capability);
        return nikonRange.Value;
    }

    private void SetRange(eNkMAIDCapability capability, double value){
        var nikonRange = _device.GetRange(capability);
        nikonRange.Value = Math.Max(nikonRange.Min, Math.Min(nikonRange.Max, value));
        _device.SetRange(eNkMAIDCapability.kNkMAIDCapability_MFDriveStep, nikonRange);
    }
}


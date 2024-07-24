// See https://aka.ms/new-console-template for more information

//using Nikon;

using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using Nikon;
using Rhombus.Slowmo;
using Rhombus.Slowmo.Nikon;

Console.WriteLine(0);

const string path = @"d:\temp\camera\take1";
const byte focusCount = 20;
const byte exposureCount = 3;
const int focusRange = 1000;
const int focusStep = focusRange / (focusCount-1);
var rotationStep = TimeSpan.FromMinutes(30);

var saveQueue = new BlockingCollection<(string filename, NikonImage image)>();
var saveTask = RunSaveQueue();

if (Directory.Exists(path)) {
    Directory.Delete(path, true);
}
Directory.CreateDirectory(path);

await using var stepper = new Stepper();
using (var manager = new Manager()) {
    var getCameraTask = manager.GetCamera();

    await stepper.SetPosition(0);

    Log("await getCamera");
    var camera = await getCameraTask;
    Log("camera found");

    camera.IsoControl = false;
    camera.Iso = Iso.ISO400;
    camera.CompressionLevel = CompressionLevel.JpegFine;
    camera.SaveMedia = SaveMedia.SDRAM;
    camera.BracketingEnabled = true;
    camera.AeBracketingStep = AEBracketingStep.Step_2EV;
    camera.ContinuousShootingNum = exposureCount;
    camera.ShootingMode = ShootingMode.Continuous_Fast;

    //camera.BracketingEnabled = false; camera.ShootingMode = (ShootingMode)0;// ShootingMode.Single;

    var rotation = TimeSpan.Zero;
    while (rotation < TimeSpan.FromHours(12)) {
        Log($"MoveTo({rotation:hhmm})");
        await Task.WhenAll(stepper.MoveTo(rotation), camera.Focus(int.MinValue));
        for (var i = 0; i < focusCount; i++) {
            var images = await camera.Capture();
            SaveImages(images, rotation, i);
            await camera.Focus(focusStep);
        };

        rotation += rotationStep;
    }
    saveQueue.CompleteAdding();

    
}

await saveTask;
return;

async Task RunSaveQueue(CancellationToken? cancellationToken = null) {
    Log("RunSaveQueue");
    await Task.Run(async () => { 
        foreach (var (filename, image) in saveQueue.GetConsumingEnumerable(cancellationToken ?? CancellationToken.None)) {
            Log($"{filename} {(File.Exists(filename) ? "(exists!)" : string.Empty)}");
            if (File.Exists(filename)) {
                File.Delete(filename);
            }

            await using var fileStream = File.OpenWrite(filename);
            await fileStream.WriteAsync(image.Buffer.AsMemory());
            Log("save complete");
        }
    });
    Log("*************** save queue complete **************");
    return;
}

void Log(object? message) {
    var backgroundColor = Console.BackgroundColor;
    var foregroundColor = Console.ForegroundColor;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(message);
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = foregroundColor;
}
void SaveImages(IEnumerable<NikonImage> exposures, TimeSpan rotation, int focusIndex) {
    ArgumentNullException.ThrowIfNull(exposures);
    Log("SaveImages");
    
        var imgList = exposures.ToList();
        for (var expIndex = 0; expIndex < imgList.Count; expIndex++) {
            var filename = Path.Combine(path, $"stack.{rotation:hhmm}.{focusIndex}.{expIndex}.jpg");
            
            saveQueue.Add((filename, imgList[expIndex]));
        }
}
/**
 * kNkMAIDCapability_Focus
 * 
 * kNkMAIDCapability_AcquireStream[Start|Stop]
 * kNkMAIDCapability_[SelfAuto]Focus[Group|Move|Help]
 * kNkMAIDCapability_QualityMode[New|Help|Group]
 *
 * kNkMAIDCapability_EVInterval
 *
 *
 *
 * kNkMAIDCapability_CompressionLevel
 * kNkMAIDCapability_ExposureMode
 * kNkMAIDCapability_ShutterSpeed
 * kNkMAIDCapability_Aperture
 * kNkMAIDCapability_FlexibleProgram
 * kNkMAIDCapability_ExposureComp
 * kNkMAIDCapability_MeteringMode
 * kNkMAIDCapability_Sensitivity
 * kNkMAIDCapability_WB[...]
 *
 * kNkMAIDCapability_EnableBracketing
 * kNkMAIDCapability_Bracketing[Order|Vary]
 * kNkMAIDCapability_AeBracketNum
 * kNkMAIDCapability_ExpCompInterval
 * kNkMAIDCapability_ShootingMode
 * kNkMAIDCapability_ContinuousShootingNum
 * kNkMAIDCapability_RemainContinuousShooting
 * kNkMAIDCapability_BracketingType
 * kNkMAIDCapability_BracketingCount
 * kNkMAIDCapability_AEBracketingStep
 *
 * kNkMAIDCapability_ShootingSpeedHigh
 *
 *
 * kNkMAIDCapability_EasyExposureComp
 * kNkMAIDCapability_EasyExposureCompMode
 *
 * kNkMAIDCapability_Microscope
 *
 * kNkMAIDCapability_Shooting[Speed|Limit]
 *
 *
 * kNkMAIDCapability_CompressRAW
 * kNkMAIDCapability_CompressRAWBitMode
 *
 * kNkMAIDCapability_IsoControl
 * kNkMAIDCapability_ISOAutoSetting
 *
 * kNkMAIDCapability_RawJpegImageStatus
 * kNkMAIDCapability_RawJpegTransferStatus
 * kNkMAIDCapability_JpegCompressionPolicy
 *
 * kNkMAIDCapability_[Image|Saturation]Setting
 * kNkMAIDCapability_ImageMode
 *
 *
 *kNkMAIDCapability_CaptureAsync
 *
 * 
 */
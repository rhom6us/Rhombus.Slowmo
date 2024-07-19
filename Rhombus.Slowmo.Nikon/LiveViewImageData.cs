using System.Runtime.InteropServices;

namespace Rhombus.Slowmo.Nikon;

[StructLayout(LayoutKind.Explicit)]
internal  struct LiveViewImageData {
    [FieldOffset(0)] public int DisplayInfoAreaSize;
    [FieldOffset(4)] public int LiveViewImageAreaSze;
    [FieldOffset(8)] public Size AttachedJpegImageSize;
    [FieldOffset(12)] public Size WholeSize;
    [FieldOffset(16)] public Size DisplayAreaSize;
    [FieldOffset(20)] public Size DisplayCenterCoordinates;
    [FieldOffset(24)] public Size AFFrameSize;
    [FieldOffset(28)] public Size AFFrameCenterCoordinates;
    [FieldOffset(36)] public byte SelectedFocusArea;
    [FieldOffset(37)] public RotationDirection RotationDirection;
    [FieldOffset(38)] public bool FocusDriving;
    [FieldOffset(46)] public UInt16 CountdownTime;
    [FieldOffset(48)] public FocusingJudgementResult FocusingJudgementResult;
    [FieldOffset(49)] public bool AFDrivingEnabled;
    [FieldOffset(64)] public uint RemainingTimeOfMovieRecording;
    [FieldOffset(68)] public byte MovieRecordingInformation;
    [FieldOffset(69)] public byte AFModeStatusOfFaceDetectionSystem;
    [FieldOffset(70)] public byte NumFacesDetected;
    [FieldOffset(71)] public byte AFAreaIndex;
    [FieldOffset(72), MarshalAs(UnmanagedType.ByValArray, SizeConst = 280)]
    public AFResult[] AFResult;
    [FieldOffset(352)] public Channels SoundLevelPeak;
    [FieldOffset(354)] public Channels SoundLevelCurrent;
    //[FieldOffset(384)][MarshalAs(UnmanagedType.ByValArray)] public Span<byte> ImageData;
}

[StructLayout(LayoutKind.Explicit)]
public struct Size {
    [FieldOffset(0)] private UInt16 Horizontal;
    [FieldOffset(2)] private UInt16 Vertical;
}

public enum RotationDirection : byte {
    None = 0,
    CounterClockwise = 1,
    Clockwise = 2,
}

public enum FocusDrivingStatus : byte {
    NotDriving = 0,
    Driving = 1,
}

public enum FocusingJudgementResult : byte {
    NoInformation = 0,
    NotFocused = 1,
    Focused = 2,
}

[StructLayout(LayoutKind.Explicit)]
public struct Channels {
    [FieldOffset(0)] public byte Left;
    [FieldOffset(1)] public byte Right;
}
[StructLayout(LayoutKind.Explicit)]
public struct AFResult {
    [FieldOffset(0)] public Size AFFrameSize;
    [FieldOffset(4)] public Size AFFrameCenterCoordinates;
}
// ReSharper disable InconsistentNaming
namespace Rhombus.Slowmo.Nikon;
using System.Reflection;

public enum DriveDirection : uint {
    InfinityToClosest = 0, // No limit -> Closest
    ClosestToInfinity = 1 // Closest -> No limit
}

public enum ShootingMode : uint {
    Single = 0,
    Continuous = 1,
    Continuous_Fast = 2,
    SelfTimer = 3,
    MirrorUp = 4,
    RemoteTimer_Instant = 5,
    RemoteTimer_2sec = 6,
    LiveView = 7,
    Quiet = 8,
    RemoteCtrl = 9,
    QuietC = 10,
    Unknown = 255
}

public enum SaveMedia : uint {
    Card = 0,
    SDRAM = 1,
    Card_SDRAM = 2
}

public enum AEBracketingStep : uint {
    Step_1_3EV = 0,
    Step_1_2EV = 1,
    Step_2_3EV = 2,
    Step_1EV = 3,
    Step_4_3EV = 4,
    Step_3_2EV = 5,
    Step_5_3EV = 6,
    Step_2EV = 7,
    Step_3EV = 8
}

public enum CompressionLevel : uint {
    [NikonPackedString("JPEG Basic")] JpegBasic = 0, //0b001
    [NikonPackedString("JPEG Normal")] JpegNormal = 1, // 0b010
    [NikonPackedString("JPEG Fine")] JpegFine = 2, // 0b011
    [NikonPackedString("RAW")] Raw = 3, // 0b100
    [NikonPackedString("RAW + JPEG Basic")] RawJpegBasic = 4, // 0b101
    [NikonPackedString("RAW + JPEG Normal")] RawJpegNormal = 5, // 0b110
    [NikonPackedString("RAW + JPEG Fine")] RawJpegFine = 6 // 0b111
}

public enum Iso : uint {
    Lo10 = 50,
    Lo08 = 56,
    Lo12 = 56,
    Lo07 = 64,
    Lo13 = 64,
    Lo05 = 72,
    Lo15 = 72,
    Lo17 = 80,
    Lo03 = 80,
    Lo02 = 90,
    Lo18 = 90,
    ISO100 = 100,
    ISO110 = 110,
    ISO125 = 125,
    ISO140 = 140,
    ISO160 = 160,
    ISO180 = 180,
    ISO200 = 200,
    ISO220 = 220,
    ISO250 = 250,
    ISO280 = 280,
    ISO320 = 320,
    ISO360 = 360,
    ISO400 = 400,
    ISO450 = 450,
    ISO500 = 500,
    ISO560 = 560,
    ISO640 = 640,
    ISO720 = 720,
    ISO800 = 800,
    ISO900 = 900,
    ISO1000 = 1000,
    ISO1100 = 1100,
    ISO1250 = 1250,
    ISO1400 = 1400,
    ISO1600 = 1600,
    ISO1800 = 1800,
    ISO2000 = 2000,
    ISO2200 = 2200,
    ISO2500 = 2500,
    ISO2800 = 2800,
    ISO3200 = 3200,
    ISO3600 = 3600,
    ISO4000 = 4000,
    ISO4500 = 4500,
    ISO5000 = 5000,
    ISO5600 = 5600,
    ISO6400 = 6400,
    ISO7200 = 7200,
    ISO8000 = 8000,
    ISO9000 = 9000,
    ISO10000 = 10000,
    ISO11000 = 11000,
    ISO12800 = 12800,
    Hi02 = 14400,
    Hi03 = 16000,
    Hi05 = 18000,
    Hi07 = 20000,
    Hi08 = 22000,
    Hi10 = 25600,
    Hi12 = 28800,
    Hi13 = 32000,
    Hi15 = 36000,
    Hi17 = 40000,
    Hi18 = 45600,
    Hi20 = 51200,
    Hi22 = 57600,
    Hi23 = 64000,
    Hi25 = 72000,
    Hi27 = 81200,
    Hi28 = 91200,
    Hi30 = 102400,
    Hi32 = 115000,
    Hi33 = 128000,
    Hi35 = 144000,
    Hi37 = 162000,
    Hi38 = 182000,
    Hi40 = 204800
}

public enum IsoAutoShutterTime : uint {
    IsoAutoShutterTime_0 = 0,   // 1/125
    IsoAutoShutterTime_1 = 1,   // 1/60
    IsoAutoShutterTime_2 = 2,   // 1/30
    IsoAutoShutterTime_3 = 3,   // 1/15
    IsoAutoShutterTime_4 = 4,   // 1/8
    IsoAutoShutterTime_5 = 5,   // 1/4
    IsoAutoShutterTime_6 = 6,   // 1/2
    IsoAutoShutterTime_7 = 7,   // 1
    IsoAutoShutterTime_8 = 8,   // 2
    IsoAutoShutterTime_9 = 9,   // 4
    IsoAutoShutterTime_10 = 10, // 8
    IsoAutoShutterTime_11 = 11, // 15
    IsoAutoShutterTime_12 = 12, // 30
    IsoAutoShutterTime_13 = 13, // 1/250
    IsoAutoShutterTime_14 = 14, // 1/200
    IsoAutoShutterTime_15 = 15, // 1/160
    IsoAutoShutterTime_16 = 16, // 1/100
    IsoAutoShutterTime_17 = 17, // 1/80
    IsoAutoShutterTime_18 = 18, // 1/40
    IsoAutoShutterTime_19 = 19, // 1/50
    IsoAutoShutterTime_20 = 20, // 1/4000
    IsoAutoShutterTime_21 = 21, // 1/3200
    IsoAutoShutterTime_22 = 22, // 1/2500
    IsoAutoShutterTime_23 = 23, // 1/2000
    IsoAutoShutterTime_24 = 24, // 1/1600
    IsoAutoShutterTime_25 = 25, // 1/1250
    IsoAutoShutterTime_26 = 26, // 1/1000
    IsoAutoShutterTime_27 = 27, // 1/800
    IsoAutoShutterTime_28 = 28, // 1/640
    IsoAutoShutterTime_29 = 29, // 1/500
    IsoAutoShutterTime_30 = 30, // 1/400
    IsoAutoShutterTime_31 = 31, // 1/320
    IsoAutoShutterTime_32 = 32  // auto
}
public enum NoiseReductionHighIso: uint {
    Off = 0,
    Normal = 1,
    High = 2,
    Low = 3,
}

[AttributeUsage(AttributeTargets.Field)]
public class NikonPackedStringAttribute(string name) : Attribute {
    public string Name { get; } = name;

    public static string? Get<T>(T value) {
        return typeof(T).GetField((value ?? throw new ArgumentNullException(nameof(value))).ToString()!)
                       ?.GetCustomAttribute<NikonPackedStringAttribute>()
                       ?.Name;
    }
}
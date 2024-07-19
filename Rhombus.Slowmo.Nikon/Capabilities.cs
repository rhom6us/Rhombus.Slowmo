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

[AttributeUsage(AttributeTargets.Field)]
public class NikonPackedStringAttribute(string name) : Attribute {
    public string Name { get; } = name;

    public static string? Get<T>(T value) {
        return typeof(T).GetField((value ?? throw new ArgumentNullException(nameof(value))).ToString()!)
                       ?.GetCustomAttribute<NikonPackedStringAttribute>()
                       ?.Name;
    }
}
namespace Rhombus.Slowmo.Firmata;
using System;
using Iot.Device.Arduino;

internal static class FirmataExtensions {
    private static bool IsInt(this double value) =>
             Math.Abs(Math.Floor(value) - value) <= Single.Epsilon;
    private static readonly double MAX_SIGNIFICAND =  Math.Pow(2, 23);
    public static void WriteCustomFloat(this FirmataCommandSequence commandSequence, double input) {

        var sign = input < 0 ? 1 : 0;
        input = Math.Abs(input);

        var base10 = (int)Math.Floor(Math.Log10(input));
        // Shift decimal to start of significand
        var exponent = 0 + base10;
        input /= Math.Pow(10, base10);

        // Shift decimal to the right as far as we can
        while (!input.IsInt() && input < MAX_SIGNIFICAND) {
            exponent -= 1;
            input *= 10;
        }

        // Reduce precision if necessary
        while (input > MAX_SIGNIFICAND) {
            exponent += 1;
            input /= 10;
        }

        var result = (int)Math.Truncate(input);
        exponent += 11;

        commandSequence.WriteByte((byte)(result & 0x7F));
        commandSequence.WriteByte((byte)((result >> 7) & 0x7F));
        commandSequence.WriteByte((byte)((result >> 14) & 0x7F));
        commandSequence.WriteByte((byte)(((result >> 21) & 0x03) | ((exponent & 0x0F) << 2) | ((sign & 0x01) << 6)));


    }
}

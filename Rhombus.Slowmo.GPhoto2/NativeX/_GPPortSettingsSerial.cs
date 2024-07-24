namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct _GPPortSettingsSerial
    {
        [NativeTypeName("char[128]")]
        public fixed sbyte port[128];

        public int speed;

        public int bits;

        [NativeTypeName("GPPortSerialParity")]
        public _GPPortSerialParity parity;

        public int stopbits;
    }
}

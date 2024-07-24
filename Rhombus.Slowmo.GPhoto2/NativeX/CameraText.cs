namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct CameraText
    {
        [NativeTypeName("char[32768]")]
        public fixed sbyte text[32768];
    }
}

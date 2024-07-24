namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct CameraFilePath
    {
        [NativeTypeName("char[128]")]
        public fixed sbyte name[128];

        [NativeTypeName("char[1024]")]
        public fixed sbyte folder[1024];
    }
}

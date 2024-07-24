namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct _CameraFileHandler
    {
        [NativeTypeName("int (*)(void *, uint64_t *)")]
        public delegate* unmanaged[Cdecl]<void*, ulong*, int> size;

        [NativeTypeName("int (*)(void *, unsigned char *, uint64_t *)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, ulong*, int> read;

        [NativeTypeName("int (*)(void *, unsigned char *, uint64_t *)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, ulong*, int> write;
    }
}

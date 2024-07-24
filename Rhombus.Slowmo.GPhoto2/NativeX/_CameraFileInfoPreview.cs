namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct _CameraFileInfoPreview
    {
        public CameraFileInfoFields fields;

        public CameraFileStatus status;

        [NativeTypeName("uint64_t")]
        public ulong size;

        [NativeTypeName("char[64]")]
        public fixed sbyte type[64];

        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;
    }
}

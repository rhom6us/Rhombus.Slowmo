namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct _CameraStorageInformation
    {
        public CameraStorageInfoFields fields;

        [NativeTypeName("char[256]")]
        public fixed sbyte basedir[256];

        [NativeTypeName("char[256]")]
        public fixed sbyte label[256];

        [NativeTypeName("char[256]")]
        public fixed sbyte description[256];

        public CameraStorageType type;

        public CameraStorageFilesystemType fstype;

        public CameraStorageAccessType access;

        [NativeTypeName("uint64_t")]
        public ulong capacitykbytes;

        [NativeTypeName("uint64_t")]
        public ulong freekbytes;

        [NativeTypeName("uint64_t")]
        public ulong freeimages;
    }
}

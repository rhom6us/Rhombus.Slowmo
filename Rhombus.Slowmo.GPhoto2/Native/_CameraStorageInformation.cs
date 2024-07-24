namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe class _CameraStorageInformation
{
    public CameraStorageInfoFields fields;

    [NativeTypeName("char[256]")]
    public string basedir;
    //public fixed sbyte basedir[256];

    [NativeTypeName("char[256]")]
    public string label;
    //public fixed sbyte label[256];

    [NativeTypeName("char[256]")]
    public string description;
    //public fixed sbyte description[256];

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

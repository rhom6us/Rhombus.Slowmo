namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe partial struct _CameraFileInfoFile
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

    public CameraFilePermissions permissions;

    [NativeTypeName("time_t")]
    public long mtime;
}

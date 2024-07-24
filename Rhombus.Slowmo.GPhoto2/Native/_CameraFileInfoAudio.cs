namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe partial struct _CameraFileInfoAudio
{
    public CameraFileInfoFields fields;

    public CameraFileStatus status;

    [NativeTypeName("uint64_t")]
    public ulong size;

    [NativeTypeName("char[64]")]
    public fixed sbyte type[64];
}

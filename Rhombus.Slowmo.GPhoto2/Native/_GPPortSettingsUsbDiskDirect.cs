namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe partial struct _GPPortSettingsUsbDiskDirect
{
    [NativeTypeName("char[128]")]
    public fixed sbyte path[128];
}

namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe partial struct _GPPortSettingsUsbScsi
{
    [NativeTypeName("char[128]")]
    public fixed sbyte path[128];
}

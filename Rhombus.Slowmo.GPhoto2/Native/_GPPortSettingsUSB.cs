namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe partial struct _GPPortSettingsUSB
{
    public int inep;

    public int outep;

    public int intep;

    public int config;

    public int @interface;

    public int altsetting;

    public int maxpacketsize;

    [NativeTypeName("char[64]")]
    public fixed sbyte port[64];
}

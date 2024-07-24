using System.Runtime.InteropServices;

namespace Rhombus.Slowmo.GPhoto2.Native;

[StructLayout(LayoutKind.Explicit)]
public partial struct _GPPortSettings
{
    [FieldOffset(0)]
    [NativeTypeName("GPPortSettingsSerial")]
    public _GPPortSettingsSerial serial;

    [FieldOffset(0)]
    [NativeTypeName("GPPortSettingsUSB")]
    public _GPPortSettingsUSB usb;

    [FieldOffset(0)]
    [NativeTypeName("GPPortSettingsUsbDiskDirect")]
    public _GPPortSettingsUsbDiskDirect usbdiskdirect;

    [FieldOffset(0)]
    [NativeTypeName("GPPortSettingsUsbScsi")]
    public _GPPortSettingsUsbScsi usbscsi;
}

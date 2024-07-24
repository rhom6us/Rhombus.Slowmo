namespace Rhombus.Slowmo.GPhoto2.Native;

public enum GPPortType
{
    GP_PORT_NONE = 0,
    GP_PORT_SERIAL = 1 << 0,
    GP_PORT_USB = 1 << 2,
    GP_PORT_DISK = 1 << 3,
    GP_PORT_PTPIP = 1 << 4,
    GP_PORT_USB_DISK_DIRECT = 1 << 5,
    GP_PORT_USB_SCSI = 1 << 6,
    GP_PORT_IP = 1 << 7,
}

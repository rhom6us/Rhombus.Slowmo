namespace Rhombus.Slowmo.GPhoto2.Native;

public enum CameraFileInfoFields
{
    GP_FILE_INFO_NONE = 0,
    GP_FILE_INFO_TYPE = 1 << 0,
    GP_FILE_INFO_SIZE = 1 << 2,
    GP_FILE_INFO_WIDTH = 1 << 3,
    GP_FILE_INFO_HEIGHT = 1 << 4,
    GP_FILE_INFO_PERMISSIONS = 1 << 5,
    GP_FILE_INFO_STATUS = 1 << 6,
    GP_FILE_INFO_MTIME = 1 << 7,
    GP_FILE_INFO_ALL = 0xFF,
}

namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public enum CameraFilePermissions
    {
        GP_FILE_PERM_NONE = 0,
        GP_FILE_PERM_READ = 1 << 0,
        GP_FILE_PERM_DELETE = 1 << 1,
        GP_FILE_PERM_ALL = 0xFF,
    }
}

namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public enum CameraStorageInfoFields
    {
        GP_STORAGEINFO_BASE = (1 << 0),
        GP_STORAGEINFO_LABEL = (1 << 1),
        GP_STORAGEINFO_DESCRIPTION = (1 << 2),
        GP_STORAGEINFO_ACCESS = (1 << 3),
        GP_STORAGEINFO_STORAGETYPE = (1 << 4),
        GP_STORAGEINFO_FILESYSTEMTYPE = (1 << 5),
        GP_STORAGEINFO_MAXCAPACITY = (1 << 6),
        GP_STORAGEINFO_FREESPACEKBYTES = (1 << 7),
        GP_STORAGEINFO_FREESPACEIMAGES = (1 << 8),
    }
}

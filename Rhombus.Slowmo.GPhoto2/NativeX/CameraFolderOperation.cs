namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public enum CameraFolderOperation
    {
        GP_FOLDER_OPERATION_NONE = 0,
        GP_FOLDER_OPERATION_DELETE_ALL = 1 << 0,
        GP_FOLDER_OPERATION_PUT_FILE = 1 << 1,
        GP_FOLDER_OPERATION_MAKE_DIR = 1 << 2,
        GP_FOLDER_OPERATION_REMOVE_DIR = 1 << 3,
    }
}

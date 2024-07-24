namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe partial struct _CameraFilesystemFuncs
{
    [NativeTypeName("CameraFilesystemListFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, _CameraList*, void*, _GPContext*, int> file_list_func;

    [NativeTypeName("CameraFilesystemListFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, _CameraList*, void*, _GPContext*, int> folder_list_func;

    [NativeTypeName("CameraFilesystemPutFileFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, CameraFileType, _CameraFile*, void*, _GPContext*, int> put_file_func;

    [NativeTypeName("CameraFilesystemDeleteAllFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, void*, _GPContext*, int> delete_all_func;

    [NativeTypeName("CameraFilesystemGetInfoFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, _CameraFileInfo*, void*, _GPContext*, int> get_info_func;

    [NativeTypeName("CameraFilesystemSetInfoFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, _CameraFileInfo, void*, _GPContext*, int> set_info_func;

    [NativeTypeName("CameraFilesystemDirFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, void*, _GPContext*, int> make_dir_func;

    [NativeTypeName("CameraFilesystemDirFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, void*, _GPContext*, int> remove_dir_func;

    [NativeTypeName("CameraFilesystemGetFileFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, CameraFileType, _CameraFile*, void*, _GPContext*, int> get_file_func;

    [NativeTypeName("CameraFilesystemReadFileFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, CameraFileType, ulong, sbyte*, ulong*, void*, _GPContext*, int> read_file_func;

    [NativeTypeName("CameraFilesystemDeleteFileFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, sbyte*, sbyte*, void*, _GPContext*, int> del_file_func;

    [NativeTypeName("CameraFilesystemStorageInfoFunc")]
    public delegate* unmanaged[Cdecl]<_CameraFilesystem*, _CameraStorageInformation**, int*, void*, _GPContext*, int> storage_info_func;

    [NativeTypeName("void *[31]")]
    public _unused_e__FixedBuffer unused;

    public unsafe partial struct _unused_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public void* e12;
        public void* e13;
        public void* e14;
        public void* e15;
        public void* e16;
        public void* e17;
        public void* e18;
        public void* e19;
        public void* e20;
        public void* e21;
        public void* e22;
        public void* e23;
        public void* e24;
        public void* e25;
        public void* e26;
        public void* e27;
        public void* e28;
        public void* e29;
        public void* e30;

        public ref void* this[int index]
        {
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}

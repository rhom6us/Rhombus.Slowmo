using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Rhombus.Slowmo.GPhoto2.NativeX {
    public struct _Camera { }

    public unsafe partial class Camera(_Camera* handle) : IDisposable {
        #region IDisposable


        private void ReleaseUnmanagedResources() {
            gp_camera_free(handle);
        }

        protected virtual void Dispose(bool disposing) {
            ReleaseUnmanagedResources();
            if (disposing) {
                // TODO release managed resources here
            }
        }

        /// <inheritdoc />
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc />
        ~Camera() {
            Dispose(false);
        }

        #endregion

        public static unsafe Camera Create() {

            gp_camera_new(out var pCamera);
            return new Camera(pCamera);
        }

        public CameraAbilities Abilities {
            get {
                gp_camera_get_abilities(handle, out var abilities);
                return abilities;
            }
            set => gp_camera_set_abilities(handle, value);
        }

        public _GPPortInfo PortInfo {
            get {
                gp_camera_get_port_info(handle, out var info);
                return *info;
            }
            set => gp_camera_set_port_info(handle, &value);
        }
        
        

        

        //[NativeTypeName("GPPort *")] public _GPPort* port;

        //[NativeTypeName("CameraFilesystem *")] public _CameraFilesystem* fs;

        //[NativeTypeName("CameraFunctions *")] public _CameraFunctions* functions;

        //[NativeTypeName("CameraPrivateLibrary *")]
        //public _CameraPrivateLibrary* pl;

        //[NativeTypeName("CameraPrivateCore *")]
        //public _CameraPrivateCore* pc;

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_new([NativeTypeName("Camera **")] out _Camera* camera);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_set_abilities([NativeTypeName("Camera *")] _Camera* camera, CameraAbilities abilities);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_abilities([NativeTypeName("Camera *")] _Camera* camera, out CameraAbilities abilities);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_set_port_info([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPPortInfo")] in _GPPortInfo* info);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_port_info([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPPortInfo *")] out _GPPortInfo* info);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_set_port_speed([NativeTypeName("Camera *")] _Camera* camera, int speed);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_port_speed([NativeTypeName("Camera *")] _Camera* camera);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_autodetect([NativeTypeName("CameraList *")] _CameraList* list, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_init([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_exit([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_ref([NativeTypeName("Camera *")] _Camera* camera);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_unref([NativeTypeName("Camera *")] _Camera* camera);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_free([NativeTypeName("Camera *")] _Camera* camera);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_config([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraWidget **")] _CameraWidget** window, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_list_config([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraList *")] _CameraList* list, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_single_config([NativeTypeName("Camera *")] _Camera* camera,
                                                             [NativeTypeName("const char *")] string name,
                                                             [NativeTypeName("CameraWidget **")] _CameraWidget** widget,
                                                             [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_set_config([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraWidget *")] _CameraWidget* window, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_set_single_config([NativeTypeName("Camera *")] _Camera* camera,
                                                             [NativeTypeName("const char *")] string name,
                                                             [NativeTypeName("CameraWidget *")] _CameraWidget* widget,
                                                             [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_summary([NativeTypeName("Camera *")] _Camera* camera, CameraText* summary, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_manual([NativeTypeName("Camera *")] _Camera* camera, CameraText* manual, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_about([NativeTypeName("Camera *")] _Camera* camera, CameraText* about, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_capture([NativeTypeName("Camera *")] _Camera* camera, CameraCaptureType type, CameraFilePath* path, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_trigger_capture([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_capture_preview([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_wait_for_event([NativeTypeName("Camera *")] _Camera* camera, int timeout, ref CameraEventType eventtype, void** eventdata, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_get_storageinfo([NativeTypeName("Camera *")] _Camera* camera,
                                                           [NativeTypeName("CameraStorageInformation **")] _CameraStorageInformation** param1,
                                                           int* param2,
                                                           [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_folder_list_files([NativeTypeName("Camera *")] _Camera* camera,
                                                             [NativeTypeName("const char *")] string folder,
                                                             [NativeTypeName("CameraList *")] _CameraList* list,
                                                             [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_folder_list_folders([NativeTypeName("Camera *")] _Camera* camera,
                                                               [NativeTypeName("const char *")] string folder,
                                                               [NativeTypeName("CameraList *")] _CameraList* list,
                                                               [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_folder_delete_all([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("const char *")] string folder, [NativeTypeName("GPContext *")] _GPContext* context);

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_folder_put_file([NativeTypeName("Camera *")] _Camera* camera,
                                                           [NativeTypeName("const char *")] string folder,
                                                           [NativeTypeName("const char *")] string filename,
                                                           CameraFileType type,
                                                           [NativeTypeName("CameraFile *")] _CameraFile* file,
                                                           [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_folder_make_dir([NativeTypeName("Camera *")] _Camera* camera,
                                                           [NativeTypeName("const char *")] string folder,
                                                           [NativeTypeName("const char *")] string name,
                                                           [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_folder_remove_dir([NativeTypeName("Camera *")] _Camera* camera,
                                                             [NativeTypeName("const char *")] string folder,
                                                             [NativeTypeName("const char *")] string name,
                                                             [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_file_get_info([NativeTypeName("Camera *")] _Camera* camera,
                                                         [NativeTypeName("const char *")] string folder,
                                                         [NativeTypeName("const char *")] string file,
                                                         [NativeTypeName("CameraFileInfo *")] _CameraFileInfo* info,
                                                         [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_file_set_info([NativeTypeName("Camera *")] _Camera* camera,
                                                         [NativeTypeName("const char *")] string folder,
                                                         [NativeTypeName("const char *")] string file,
                                                         [NativeTypeName("CameraFileInfo")] _CameraFileInfo info,
                                                         [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_file_get([NativeTypeName("Camera *")] _Camera* camera,
                                                    [NativeTypeName("const char *")] string folder,
                                                    [NativeTypeName("const char *")] string file,
                                                    CameraFileType type,
                                                    [NativeTypeName("CameraFile *")] _CameraFile* camera_file,
                                                    [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_file_read([NativeTypeName("Camera *")] _Camera* camera,
                                                     [NativeTypeName("const char *")] string folder,
                                                     [NativeTypeName("const char *")] string file,
                                                     CameraFileType type,
                                                     [NativeTypeName("uint64_t")] ulong offset,
                                                     [NativeTypeName("char *")] string buf,
                                                     [NativeTypeName("uint64_t *")] ulong* size,
                                                     [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_file_delete([NativeTypeName("Camera *")] _Camera* camera,
                                                       [NativeTypeName("const char *")] string folder,
                                                       [NativeTypeName("const char *")] string file,
                                                       [NativeTypeName("GPContext *")] _GPContext* context
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial void gp_camera_set_timeout_funcs([NativeTypeName("Camera *")] _Camera* camera,
                                                              [NativeTypeName("CameraTimeoutStartFunc")] delegate* unmanaged[Cdecl]<_Camera*, uint, delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int>, void*, uint> start_func,
                                                              [NativeTypeName("CameraTimeoutStopFunc")] delegate* unmanaged[Cdecl]<_Camera*, uint, void*, void> stop_func,
                                                              void* data
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial int gp_camera_start_timeout([NativeTypeName("Camera *")] _Camera* camera,
                                                         [NativeTypeName("unsigned int")] uint timeout,
                                                         [NativeTypeName("CameraTimeoutFunc")] delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int> func
        );

        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static unsafe partial void gp_camera_stop_timeout([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("unsigned int")] uint id);
    }
}
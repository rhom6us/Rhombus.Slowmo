namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct _CameraFunctions
    {
        [NativeTypeName("CameraPrePostFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int> pre_func;

        [NativeTypeName("CameraPrePostFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int> post_func;

        [NativeTypeName("CameraExitFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int> exit;

        [NativeTypeName("CameraGetConfigFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _CameraWidget**, _GPContext*, int> get_config;

        [NativeTypeName("CameraSetConfigFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _CameraWidget*, _GPContext*, int> set_config;

        [NativeTypeName("CameraListConfigFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _CameraList*, _GPContext*, int> list_config;

        [NativeTypeName("CameraGetSingleConfigFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, sbyte*, _CameraWidget**, _GPContext*, int> get_single_config;

        [NativeTypeName("CameraSetSingleConfigFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, sbyte*, _CameraWidget*, _GPContext*, int> set_single_config;

        [NativeTypeName("CameraCaptureFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, CameraCaptureType, CameraFilePath*, _GPContext*, int> capture;

        [NativeTypeName("CameraTriggerCaptureFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int> trigger_capture;

        [NativeTypeName("CameraCapturePreviewFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, _CameraFile*, _GPContext*, int> capture_preview;

        [NativeTypeName("CameraSummaryFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, CameraText*, _GPContext*, int> summary;

        [NativeTypeName("CameraManualFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, CameraText*, _GPContext*, int> manual;

        [NativeTypeName("CameraAboutFunc")]
        public delegate* unmanaged[Cdecl]<_Camera*, CameraText*, _GPContext*, int> about;

        [NativeTypeName("CameraWaitForEvent")]
        public delegate* unmanaged[Cdecl]<_Camera*, int, CameraEventType*, void**, _GPContext*, int> wait_for_event;

        public void* reserved1;

        public void* reserved2;

        public void* reserved3;

        public void* reserved4;

        public void* reserved5;

        public void* reserved6;

        public void* reserved7;

        public void* reserved8;
    }
}

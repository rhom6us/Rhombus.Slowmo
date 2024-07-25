using System.Runtime.CompilerServices;


using System.Runtime.InteropServices;



namespace Rhombus.Slowmo.GPhoto2.NativeX {
    public unsafe partial struct _GPContext {
        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        [return: NativeTypeName("GPContext *")]
        public static partial _GPContext* gp_context_new();



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_ref([NativeTypeName("GPContext *")] _GPContext* context);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_unref([NativeTypeName("GPContext *")] _GPContext* context);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_idle_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextIdleFunc")] delegate* unmanaged[Cdecl]<_GPContext*, void*, void> func, void* data);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_progress_funcs([NativeTypeName("GPContext *")] _GPContext* context,
                                                                 [NativeTypeName("GPContextProgressStartFunc")] delegate* unmanaged[Cdecl]<_GPContext*, float, string, void*, uint> start_func,
                                                                 [NativeTypeName("GPContextProgressUpdateFunc")] delegate* unmanaged[Cdecl]<_GPContext*, uint, float, void*, void> update_func,
                                                                 [NativeTypeName("GPContextProgressStopFunc")] delegate* unmanaged[Cdecl]<_GPContext*, uint, void*, void> stop_func,
                                                                 void* data
        );



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_error_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextErrorFunc")] delegate* unmanaged[Cdecl]<_GPContext*, string, void*, void> func, void* data);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_status_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextStatusFunc")] delegate* unmanaged[Cdecl]<_GPContext*, string, void*, void> func, void* data);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_question_func([NativeTypeName("GPContext *")] _GPContext* context,
                                                                [NativeTypeName("GPContextQuestionFunc")] delegate* unmanaged[Cdecl]<_GPContext*, string, void*, _GPContextFeedback> func,
                                                                void* data
        );



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_cancel_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextCancelFunc")] delegate* unmanaged[Cdecl]<_GPContext*, void*, _GPContextFeedback> func, void* data);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_set_message_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextMessageFunc")] delegate* unmanaged[Cdecl]<_GPContext*, string, void*, void> func, void* data);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_idle([NativeTypeName("GPContext *")] _GPContext* context);



        //[LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        // static partial void gp_context_error([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] string format, __arglist);



        //[LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        // static partial void gp_context_status([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] string format, __arglist);



//        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
//         static partial void gp_context_message([NativeTypeName("GPContext *")] ref _GPContext context, [NativeTypeName("const char *")] string format);

////, in void*[] arglist);



//        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
//        [return: NativeTypeName("GPContextFeedback")]
//        public static partial _GPContextFeedback gp_context_question([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] string format);

////, __arglist);





        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        [return: NativeTypeName("GPContextFeedback")]
        public static partial _GPContextFeedback gp_context_cancel([NativeTypeName("GPContext *")] _GPContext* context);



        //[LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        //[return: NativeTypeName("unsigned int")]
        //static partial uint gp_context_progress_start([NativeTypeName("GPContext *")] _GPContext* context, float target, [NativeTypeName("const char *")] string format_, __arglist);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_progress_update([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("unsigned int")] uint id, float current);



        [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf8), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void gp_context_progress_stop([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("unsigned int")] uint id);


    }
}
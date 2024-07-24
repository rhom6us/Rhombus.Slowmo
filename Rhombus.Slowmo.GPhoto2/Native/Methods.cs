using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


#pragma warning disable CA1401

namespace Rhombus.Slowmo.GPhoto2.Native;


internal static unsafe partial class Methods {
 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] [return: NativeTypeName("GPContext *")] internal static partial _GPContext* gp_context_new();


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_ref([NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_unref([NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_idle_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextIdleFunc")] delegate* unmanaged[Cdecl]<_GPContext*, void*, void> func, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_progress_funcs([NativeTypeName("GPContext *")] _GPContext* context,
 //                                                           [NativeTypeName("GPContextProgressStartFunc")] delegate* unmanaged[Cdecl]<_GPContext*, float, sbyte*, void*, uint> start_func,
 //                                                           [NativeTypeName("GPContextProgressUpdateFunc")] delegate* unmanaged[Cdecl]<_GPContext*, uint, float, void*, void> update_func,
 //                                                           [NativeTypeName("GPContextProgressStopFunc")] delegate* unmanaged[Cdecl]<_GPContext*, uint, void*, void> stop_func,
 //                                                           void* data
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_error_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextErrorFunc")] delegate* unmanaged[Cdecl]<_GPContext*, sbyte*, void*, void> func, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_status_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextStatusFunc")] delegate* unmanaged[Cdecl]<_GPContext*, sbyte*, void*, void> func, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_question_func([NativeTypeName("GPContext *")] _GPContext* context,
 //                                                          [NativeTypeName("GPContextQuestionFunc")] delegate* unmanaged[Cdecl]<_GPContext*, sbyte*, void*, _GPContextFeedback> func,
 //                                                          void* data
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_cancel_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextCancelFunc")] delegate* unmanaged[Cdecl]<_GPContext*, void*, _GPContextFeedback> func, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_set_message_func([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("GPContextMessageFunc")] delegate* unmanaged[Cdecl]<_GPContext*, sbyte*, void*, void> func, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_idle([NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_error([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_status([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_message([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] [return: NativeTypeName("GPContextFeedback")] internal static partial _GPContextFeedback gp_context_question([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] [return: NativeTypeName("GPContextFeedback")] internal static partial _GPContextFeedback gp_context_cancel([NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] [return: NativeTypeName("unsigned int")] internal static partial uint gp_context_progress_start([NativeTypeName("GPContext *")] _GPContext* context, float target, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_progress_update([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("unsigned int")] uint id, float current);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_context_progress_stop([NativeTypeName("GPContext *")] _GPContext* context, [NativeTypeName("unsigned int")] uint id);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_new([NativeTypeName("CameraList **")] _CameraList** list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_ref([NativeTypeName("CameraList *")] _CameraList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_unref([NativeTypeName("CameraList *")] _CameraList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_free([NativeTypeName("CameraList *")] _CameraList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_count([NativeTypeName("CameraList *")] _CameraList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_append([NativeTypeName("CameraList *")] _CameraList* list, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_reset([NativeTypeName("CameraList *")] _CameraList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_sort([NativeTypeName("CameraList *")] _CameraList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_find_by_name([NativeTypeName("CameraList *")] _CameraList* list, int* index, [NativeTypeName("const char *")] sbyte* name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_get_name([NativeTypeName("CameraList *")] _CameraList* list, int index, [NativeTypeName("const char **")] sbyte** name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_get_value([NativeTypeName("CameraList *")] _CameraList* list, int index, [NativeTypeName("const char **")] sbyte** value);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_set_name([NativeTypeName("CameraList *")] _CameraList* list, int index, [NativeTypeName("const char *")] sbyte* name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_set_value([NativeTypeName("CameraList *")] _CameraList* list, int index, [NativeTypeName("const char *")] sbyte* value);



 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_new([NativeTypeName("GPPort **")] _GPPort** port);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_free([NativeTypeName("GPPort *")] _GPPort* port);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_set_info([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("GPPortInfo")] _GPPortInfo* info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_get_info([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("GPPortInfo *")] _GPPortInfo** info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_open([NativeTypeName("GPPort *")] _GPPort* port);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_close([NativeTypeName("GPPort *")] _GPPort* port);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_reset([NativeTypeName("GPPort *")] _GPPort* port);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_write([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("const char *")] sbyte* data, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_read([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("char *")] sbyte* data, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_check_int([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("char *")] sbyte* data, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_check_int_fast([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("char *")] sbyte* data, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_get_timeout([NativeTypeName("GPPort *")] _GPPort* port, int* timeout);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_set_timeout([NativeTypeName("GPPort *")] _GPPort* port, int timeout);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_set_settings([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("GPPortSettings")] _GPPortSettings settings);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_get_settings([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("GPPortSettings *")] _GPPortSettings* settings);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_get_pin([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("GPPin")] _GPPin pin, [NativeTypeName("GPLevel *")] _GPLevel* level);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_set_pin([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("GPPin")] _GPPin pin, [NativeTypeName("GPLevel")] _GPLevel level);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_send_break([NativeTypeName("GPPort *")] _GPPort* port, int duration);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_flush([NativeTypeName("GPPort *")] _GPPort* port, int direction);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_set_sys_device(int fd);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_get_sys_device();


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_find_device([NativeTypeName("GPPort *")] _GPPort* port, int idvendor, int idproduct);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_find_device_by_class([NativeTypeName("GPPort *")] _GPPort* port, int mainclass, int subclass, int protocol);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_clear_halt([NativeTypeName("GPPort *")] _GPPort* port, int ep);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_msg_write([NativeTypeName("GPPort *")] _GPPort* port, int request, int value, int index, [NativeTypeName("char *")] sbyte* bytes, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_msg_read([NativeTypeName("GPPort *")] _GPPort* port, int request, int value, int index, [NativeTypeName("char *")] sbyte* bytes, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_msg_interface_write([NativeTypeName("GPPort *")] _GPPort* port, int request, int value, int index, [NativeTypeName("char *")] sbyte* bytes, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_msg_interface_read([NativeTypeName("GPPort *")] _GPPort* port, int request, int value, int index, [NativeTypeName("char *")] sbyte* bytes, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_msg_class_write([NativeTypeName("GPPort *")] _GPPort* port, int request, int value, int index, [NativeTypeName("char *")] sbyte* bytes, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_usb_msg_class_read([NativeTypeName("GPPort *")] _GPPort* port, int request, int value, int index, [NativeTypeName("char *")] sbyte* bytes, int size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_seek([NativeTypeName("GPPort *")] _GPPort* port, int offset, int whence);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_send_scsi_cmd([NativeTypeName("GPPort *")] _GPPort* port,
 //                                                  int to_dev,
 //                                                  [NativeTypeName("char *")] sbyte* cmd,
 //                                                  int cmd_size,
 //                                                  [NativeTypeName("char *")] sbyte* sense,
 //                                                  int sense_size,
 //                                                  [NativeTypeName("char *")] sbyte* data,
 //                                                  int data_size
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_set_error([NativeTypeName("GPPort *")] _GPPort* port, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] //[return: NativeTypeName("const char *")] internal static partial sbyte* gp_port_get_error([NativeTypeName("GPPort *")] _GPPort* port);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_new([NativeTypeName("GPPortInfo *")] _GPPortInfo** info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_get_name([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("char **")] sbyte** name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_set_name([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("const char *")] sbyte* name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_get_path([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("char **")] sbyte** path);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_set_path([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("const char *")] sbyte* path);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_get_type([NativeTypeName("GPPortInfo")] _GPPortInfo* info, GPPortType* type);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_set_type([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("const GPPortType")] GPPortType type);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_get_library_filename([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("char **")] sbyte** lib);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_set_library_filename([NativeTypeName("GPPortInfo")] _GPPortInfo* info, [NativeTypeName("char *")] sbyte* lib);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_new([NativeTypeName("GPPortInfoList **")] _GPPortInfoList** list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_free([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_append([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list, [NativeTypeName("GPPortInfo")] _GPPortInfo* info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_load([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_count([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_lookup_path([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list, [NativeTypeName("const char *")] sbyte* path);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_lookup_name([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list, [NativeTypeName("const char *")] sbyte* name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_info_list_get_info([NativeTypeName("GPPortInfoList *")] _GPPortInfoList* list, int n, [NativeTypeName("GPPortInfo *")] _GPPortInfo** info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] //[return: NativeTypeName("const char *")] internal static partial sbyte* gp_port_message_codeset([NativeTypeName("const char *")] sbyte* param0);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_port_init_localedir([NativeTypeName("const char *")] sbyte* localedir);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_log_add_func(GPLogLevel level, [NativeTypeName("GPLogFunc")] delegate* unmanaged[Cdecl]<GPLogLevel, sbyte*, sbyte*, void*, void> func, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_log_remove_func(int id);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_log(GPLogLevel level, [NativeTypeName("const char *")] sbyte* domain, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_log_with_source_location(GPLogLevel level, [NativeTypeName("const char *")] sbyte* file, int line, [NativeTypeName("const char *")] sbyte* func, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_logv(GPLogLevel level, [NativeTypeName("const char *")] sbyte* domain, [NativeTypeName("const char *")] sbyte* format, [NativeTypeName("va_list")] sbyte* args);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_log_data([NativeTypeName("const char *")] sbyte* domain, [NativeTypeName("const char *")] sbyte* data, [NativeTypeName("unsigned int")] uint size, [NativeTypeName("const char *")] sbyte* format, __arglist);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_new([NativeTypeName("CameraAbilitiesList **")] _CameraAbilitiesList** list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_free([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_load([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list, [NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_load_dir([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list, [NativeTypeName("const char *")] sbyte* dir, [NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_reset([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_detect([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list,
 //                                                     [NativeTypeName("GPPortInfoList *")] _GPPortInfoList* info_list,
 //                                                     [NativeTypeName("CameraList *")] _CameraList* l,
 //                                                     [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_append([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list, CameraAbilities abilities);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_count([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_lookup_model([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list, [NativeTypeName("const char *")] sbyte* model);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_abilities_list_get_abilities([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list, int index, CameraAbilities* abilities);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] //[return: NativeTypeName("const char *")] internal static partial sbyte* gp_message_codeset([NativeTypeName("const char *")] sbyte* param0);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_init_localedir([NativeTypeName("const char *")] sbyte* localedir);



 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_new(CameraWidgetType type, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("CameraWidget **")] _CameraWidget** widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_free([NativeTypeName("CameraWidget *")] _CameraWidget* widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_ref([NativeTypeName("CameraWidget *")] _CameraWidget* widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_unref([NativeTypeName("CameraWidget *")] _CameraWidget* widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_append([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("CameraWidget *")] _CameraWidget* child);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_prepend([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("CameraWidget *")] _CameraWidget* child);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_count_children([NativeTypeName("CameraWidget *")] _CameraWidget* widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_child([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int child_number, [NativeTypeName("CameraWidget **")] _CameraWidget** child);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_child_by_label([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("CameraWidget **")] _CameraWidget** child);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_child_by_id([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int id, [NativeTypeName("CameraWidget **")] _CameraWidget** child);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_child_by_name([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("CameraWidget **")] _CameraWidget** child);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_root([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("CameraWidget **")] _CameraWidget** root);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_parent([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("CameraWidget **")] _CameraWidget** parent);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_set_value([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const void *")] void* value);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_value([NativeTypeName("CameraWidget *")] _CameraWidget* widget, void* value);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_set_name([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char *")] sbyte* name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_name([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char **")] sbyte** name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_set_info([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char *")] sbyte* info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_info([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char **")] sbyte** info);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_id([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int* id);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_type([NativeTypeName("CameraWidget *")] _CameraWidget* widget, CameraWidgetType* type);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_label([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char **")] sbyte** label);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_set_range([NativeTypeName("CameraWidget *")] _CameraWidget* range, float low, float high, float increment);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_range([NativeTypeName("CameraWidget *")] _CameraWidget* range, float* min, float* max, float* increment);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_add_choice([NativeTypeName("CameraWidget *")] _CameraWidget* widget, [NativeTypeName("const char *")] sbyte* choice);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_count_choices([NativeTypeName("CameraWidget *")] _CameraWidget* widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_choice([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int choice_number, [NativeTypeName("const char **")] sbyte** choice);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_changed([NativeTypeName("CameraWidget *")] _CameraWidget* widget);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_set_changed([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int changed);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_set_readonly([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int @readonly);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_widget_get_readonly([NativeTypeName("CameraWidget *")] _CameraWidget* widget, int* @readonly);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_new([NativeTypeName("CameraFile **")] _CameraFile** file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_new_from_fd([NativeTypeName("CameraFile **")] _CameraFile** file, int fd);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_new_from_handler([NativeTypeName("CameraFile **")] _CameraFile** file, [NativeTypeName("CameraFileHandler *")] _CameraFileHandler* handler, void* priv);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_ref([NativeTypeName("CameraFile *")] _CameraFile* file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_unref([NativeTypeName("CameraFile *")] _CameraFile* file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_free([NativeTypeName("CameraFile *")] _CameraFile* file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_set_name([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char *")] sbyte* name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_get_name([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char **")] sbyte** name);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_set_mime_type([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char *")] sbyte* mime_type);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_get_mime_type([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char **")] sbyte** mime_type);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_set_mtime([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("time_t")] long mtime);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_get_mtime([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("time_t *")] long* mtime);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_detect_mime_type([NativeTypeName("CameraFile *")] _CameraFile* file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_adjust_name_for_mime_type([NativeTypeName("CameraFile *")] _CameraFile* file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_get_name_by_type([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char *")] sbyte* basename, CameraFileType type, [NativeTypeName("char **")] sbyte** newname);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_set_data_and_size([NativeTypeName("CameraFile *")] _CameraFile* param0, [NativeTypeName("char *")] sbyte* data, [NativeTypeName("unsigned long")] uint size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_get_data_and_size([NativeTypeName("CameraFile *")] _CameraFile* param0, [NativeTypeName("const char **")] sbyte** data, [NativeTypeName("unsigned long *")] uint* size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_open([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char *")] sbyte* filename);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_save([NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("const char *")] sbyte* filename);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_clean([NativeTypeName("CameraFile *")] _CameraFile* file);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_copy([NativeTypeName("CameraFile *")] _CameraFile* destination, [NativeTypeName("CameraFile *")] _CameraFile* source);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_append([NativeTypeName("CameraFile *")] _CameraFile* param0, [NativeTypeName("const char *")] sbyte* data, [NativeTypeName("unsigned long")] uint size);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_file_slurp([NativeTypeName("CameraFile *")] _CameraFile* param0, [NativeTypeName("char *")] sbyte* data, [NativeTypeName("size_t")] nuint size, [NativeTypeName("size_t *")] nuint* readlen);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_new([NativeTypeName("CameraFilesystem **")] _CameraFilesystem** fs);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_free([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_append([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                 [NativeTypeName("const char *")] sbyte* folder,
 //                                                 [NativeTypeName("const char *")] sbyte* filename,
 //                                                 [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_set_info_noop([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                        [NativeTypeName("const char *")] sbyte* folder,
 //                                                        [NativeTypeName("const char *")] sbyte* filename,
 //                                                        [NativeTypeName("CameraFileInfo")] _CameraFileInfo info,
 //                                                        [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_set_info_dirty([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                         [NativeTypeName("const char *")] sbyte* folder,
 //                                                         [NativeTypeName("const char *")] sbyte* filename,
 //                                                         [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_set_file_noop([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                        [NativeTypeName("const char *")] sbyte* folder,
 //                                                        [NativeTypeName("const char *")] sbyte* filename,
 //                                                        CameraFileType type,
 //                                                        [NativeTypeName("CameraFile *")] _CameraFile* file,
 //                                                        [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_delete_file_noop([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                           [NativeTypeName("const char *")] sbyte* folder,
 //                                                           [NativeTypeName("const char *")] sbyte* filename,
 //                                                           [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_reset([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_count([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs, [NativeTypeName("const char *")] sbyte* folder, [NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_name([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                               [NativeTypeName("const char *")] sbyte* folder,
 //                                               int filenumber,
 //                                               [NativeTypeName("const char **")] sbyte** filename,
 //                                               [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_get_folder([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                     [NativeTypeName("const char *")] sbyte* filename,
 //                                                     [NativeTypeName("char **")] sbyte** folder,
 //                                                     [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_number([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                 [NativeTypeName("const char *")] sbyte* folder,
 //                                                 [NativeTypeName("const char *")] sbyte* filename,
 //                                                 [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_list_files([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                     [NativeTypeName("const char *")] sbyte* folder,
 //                                                     [NativeTypeName("CameraList *")] _CameraList* list,
 //                                                     [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_list_folders([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                       [NativeTypeName("const char *")] sbyte* folder,
 //                                                       [NativeTypeName("CameraList *")] _CameraList* list,
 //                                                       [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_get_info([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                   [NativeTypeName("const char *")] sbyte* folder,
 //                                                   [NativeTypeName("const char *")] sbyte* filename,
 //                                                   [NativeTypeName("CameraFileInfo *")] _CameraFileInfo* info,
 //                                                   [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_set_info([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                   [NativeTypeName("const char *")] sbyte* folder,
 //                                                   [NativeTypeName("const char *")] sbyte* filename,
 //                                                   [NativeTypeName("CameraFileInfo")] _CameraFileInfo info,
 //                                                   [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_get_file([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                   [NativeTypeName("const char *")] sbyte* folder,
 //                                                   [NativeTypeName("const char *")] sbyte* filename,
 //                                                   CameraFileType type,
 //                                                   [NativeTypeName("CameraFile *")] _CameraFile* file,
 //                                                   [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_read_file([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                    [NativeTypeName("const char *")] sbyte* folder,
 //                                                    [NativeTypeName("const char *")] sbyte* filename,
 //                                                    CameraFileType type,
 //                                                    [NativeTypeName("uint64_t")] ulong offset,
 //                                                    [NativeTypeName("char *")] sbyte* buf,
 //                                                    [NativeTypeName("uint64_t *")] ulong* size,
 //                                                    [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_delete_file([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                      [NativeTypeName("const char *")] sbyte* folder,
 //                                                      [NativeTypeName("const char *")] sbyte* filename,
 //                                                      [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_get_storageinfo([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                          [NativeTypeName("CameraStorageInformation **")] _CameraStorageInformation** param1,
 //                                                          int* nrofstorageinformations,
 //                                                          [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_set_funcs([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs, [NativeTypeName("CameraFilesystemFuncs *")] _CameraFilesystemFuncs* funcs, void* data);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_put_file([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                   [NativeTypeName("const char *")] sbyte* folder,
 //                                                   [NativeTypeName("const char *")] sbyte* filename,
 //                                                   CameraFileType type,
 //                                                   [NativeTypeName("CameraFile *")] _CameraFile* file,
 //                                                   [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_delete_all([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs, [NativeTypeName("const char *")] sbyte* folder, [NativeTypeName("GPContext *")] _GPContext* context);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_make_dir([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                   [NativeTypeName("const char *")] sbyte* folder,
 //                                                   [NativeTypeName("const char *")] sbyte* name,
 //                                                   [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_remove_dir([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs,
 //                                                     [NativeTypeName("const char *")] sbyte* folder,
 //                                                     [NativeTypeName("const char *")] sbyte* name,
 //                                                     [NativeTypeName("GPContext *")] _GPContext* context
 //   );


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_filesystem_dump([NativeTypeName("CameraFilesystem *")] _CameraFilesystem* fs);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] //[return: NativeTypeName("const char *")] internal static partial sbyte* gp_port_result_as_string(int result);


 //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] //[return: NativeTypeName("const char *")] internal static partial sbyte* gp_result_as_string(int result);


    
    [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_new([NativeTypeName("Camera **")] _Camera** camera);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_set_abilities([NativeTypeName("Camera *")] _Camera* camera, CameraAbilities abilities);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_abilities([NativeTypeName("Camera *")] _Camera* camera, CameraAbilities* abilities);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_set_port_info([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPPortInfo")] _GPPortInfo* info);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_port_info([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPPortInfo *")] _GPPortInfo** info);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_set_port_speed([NativeTypeName("Camera *")] _Camera* camera, int speed);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_port_speed([NativeTypeName("Camera *")] _Camera* camera);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_autodetect([NativeTypeName("CameraList *")] _CameraList* list, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_init([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_exit([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_ref([NativeTypeName("Camera *")] _Camera* camera);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_unref([NativeTypeName("Camera *")] _Camera* camera);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_free([NativeTypeName("Camera *")] _Camera* camera);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_config([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraWidget **")] _CameraWidget** window, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_list_config([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraList *")] _CameraList* list, [NativeTypeName("GPContext *")] _GPContext* context);


    [LibraryImport("libgphoto2", StringMarshalling = StringMarshalling.Utf16), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
    internal static partial int gp_camera_get_single_config([NativeTypeName("Camera *")] _Camera* camera,
                                                         [NativeTypeName("const char *")] string name,
                                                         [NativeTypeName("CameraWidget **")] _CameraWidget** widget,
                                                         [NativeTypeName("GPContext *")] _GPContext* context
    );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_set_config([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraWidget *")] _CameraWidget* window, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_set_single_config([NativeTypeName("Camera *")] _Camera* camera,
    //                                                        [NativeTypeName("const char *")] sbyte* name,
    //                                                        [NativeTypeName("CameraWidget *")] _CameraWidget* widget,
    //                                                        [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_summary([NativeTypeName("Camera *")] _Camera* camera, CameraText* summary, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_manual([NativeTypeName("Camera *")] _Camera* camera, CameraText* manual, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_about([NativeTypeName("Camera *")] _Camera* camera, CameraText* about, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_capture([NativeTypeName("Camera *")] _Camera* camera, CameraCaptureType type, CameraFilePath* path, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_trigger_capture([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_capture_preview([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("CameraFile *")] _CameraFile* file, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_wait_for_event([NativeTypeName("Camera *")] _Camera* camera, int timeout, CameraEventType* eventtype, void** eventdata, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_get_storageinfo([NativeTypeName("Camera *")] _Camera* camera,
    //                                                      [NativeTypeName("CameraStorageInformation **")] _CameraStorageInformation** param1,
    //                                                      int* param2,
    //                                                      [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_folder_list_files([NativeTypeName("Camera *")] _Camera* camera,
    //                                                        [NativeTypeName("const char *")] sbyte* folder,
    //                                                        [NativeTypeName("CameraList *")] _CameraList* list,
    //                                                        [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_folder_list_folders([NativeTypeName("Camera *")] _Camera* camera,
    //                                                          [NativeTypeName("const char *")] sbyte* folder,
    //                                                          [NativeTypeName("CameraList *")] _CameraList* list,
    //                                                          [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_folder_delete_all([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("const char *")] sbyte* folder, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_folder_put_file([NativeTypeName("Camera *")] _Camera* camera,
    //                                                      [NativeTypeName("const char *")] sbyte* folder,
    //                                                      [NativeTypeName("const char *")] sbyte* filename,
    //                                                      CameraFileType type,
    //                                                      [NativeTypeName("CameraFile *")] _CameraFile* file,
    //                                                      [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_folder_make_dir([NativeTypeName("Camera *")] _Camera* camera,
    //                                                      [NativeTypeName("const char *")] sbyte* folder,
    //                                                      [NativeTypeName("const char *")] sbyte* name,
    //                                                      [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_folder_remove_dir([NativeTypeName("Camera *")] _Camera* camera,
    //                                                        [NativeTypeName("const char *")] sbyte* folder,
    //                                                        [NativeTypeName("const char *")] sbyte* name,
    //                                                        [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_file_get_info([NativeTypeName("Camera *")] _Camera* camera,
    //                                                    [NativeTypeName("const char *")] sbyte* folder,
    //                                                    [NativeTypeName("const char *")] sbyte* file,
    //                                                    [NativeTypeName("CameraFileInfo *")] _CameraFileInfo* info,
    //                                                    [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_file_set_info([NativeTypeName("Camera *")] _Camera* camera,
    //                                                    [NativeTypeName("const char *")] sbyte* folder,
    //                                                    [NativeTypeName("const char *")] sbyte* file,
    //                                                    [NativeTypeName("CameraFileInfo")] _CameraFileInfo info,
    //                                                    [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_file_get([NativeTypeName("Camera *")] _Camera* camera,
    //                                               [NativeTypeName("const char *")] sbyte* folder,
    //                                               [NativeTypeName("const char *")] sbyte* file,
    //                                               CameraFileType type,
    //                                               [NativeTypeName("CameraFile *")] _CameraFile* camera_file,
    //                                               [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_file_read([NativeTypeName("Camera *")] _Camera* camera,
    //                                                [NativeTypeName("const char *")] sbyte* folder,
    //                                                [NativeTypeName("const char *")] sbyte* file,
    //                                                CameraFileType type,
    //                                                [NativeTypeName("uint64_t")] ulong offset,
    //                                                [NativeTypeName("char *")] sbyte* buf,
    //                                                [NativeTypeName("uint64_t *")] ulong* size,
    //                                                [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_file_delete([NativeTypeName("Camera *")] _Camera* camera,
    //                                                  [NativeTypeName("const char *")] sbyte* folder,
    //                                                  [NativeTypeName("const char *")] sbyte* file,
    //                                                  [NativeTypeName("GPContext *")] _GPContext* context
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_camera_set_timeout_funcs([NativeTypeName("Camera *")] _Camera* camera,
    //                                                         [NativeTypeName("CameraTimeoutStartFunc")] delegate* unmanaged[Cdecl]<_Camera*, uint, delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int>, void*, uint> start_func,
    //                                                         [NativeTypeName("CameraTimeoutStopFunc")] delegate* unmanaged[Cdecl]<_Camera*, uint, void*, void> stop_func,
    //                                                         void* data
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_camera_start_timeout([NativeTypeName("Camera *")] _Camera* camera,
    //                                                    [NativeTypeName("unsigned int")] uint timeout,
    //                                                    [NativeTypeName("CameraTimeoutFunc")] delegate* unmanaged[Cdecl]<_Camera*, _GPContext*, int> func
    //   );


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] static partial void gp_camera_stop_timeout([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("unsigned int")] uint id);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_list_populate([NativeTypeName("CameraList *")] _CameraList* list, [NativeTypeName("const char *")] sbyte* format, int count);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int camera_id(CameraText* id);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int camera_abilities([NativeTypeName("CameraAbilitiesList *")] _CameraAbilitiesList* list);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int camera_init([NativeTypeName("Camera *")] _Camera* camera, [NativeTypeName("GPContext *")] _GPContext* context);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_setting_set([NativeTypeName("char *")] sbyte* id, [NativeTypeName("char *")] sbyte* key, [NativeTypeName("char *")] sbyte* value);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })] internal static partial int gp_setting_get([NativeTypeName("char *")] sbyte* id, [NativeTypeName("char *")] sbyte* key, [NativeTypeName("char *")] sbyte* value);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
    //[return: NativeTypeName("const char **")] internal static partial sbyte** gp_port_library_version(GPVersionVerbosity verbose);


    //   [LibraryImport("libgphoto2"), UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvCdecl) })]
    //[return: NativeTypeName("const char **")] internal static partial sbyte** gp_library_version(GPVersionVerbosity verbose);


    //   internal const int GP_PORT_USB_ENDPOINT_IN = 0;

    //   internal const int GP_PORT_USB_ENDPOINT_OUT = 1;

    //   internal const int GP_PORT_USB_ENDPOINT_INT = 2;

}
namespace Rhombus.Slowmo.GPhoto2.Native;

public unsafe class _Camera
{
    [NativeTypeName("GPPort *")]
    public _GPPort* port;

    [NativeTypeName("CameraFilesystem *")]
    public _CameraFilesystem* fs;

    [NativeTypeName("CameraFunctions *")]
    public _CameraFunctions* functions;

    [NativeTypeName("CameraPrivateLibrary *")]
    public _CameraPrivateLibrary* pl;

    [NativeTypeName("CameraPrivateCore *")]
    public _CameraPrivateCore* pc;
}

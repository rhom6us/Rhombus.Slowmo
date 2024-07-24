namespace Rhombus.Slowmo.GPhoto2.Native;

public partial struct _CameraFileInfo
{
    [NativeTypeName("CameraFileInfoPreview")]
    public _CameraFileInfoPreview preview;

    [NativeTypeName("CameraFileInfoFile")]
    public _CameraFileInfoFile file;

    [NativeTypeName("CameraFileInfoAudio")]
    public _CameraFileInfoAudio audio;
}

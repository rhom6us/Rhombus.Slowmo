namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct CameraAbilities
    {
        [NativeTypeName("char[128]")]
        public fixed sbyte model[128];

        public CameraDriverStatus status;

        public GPPortType port;

        [NativeTypeName("int[64]")]
        public fixed int speed[64];

        public CameraOperation operations;

        public CameraFileOperation file_operations;

        public CameraFolderOperation folder_operations;

        public int usb_vendor;

        public int usb_product;

        public int usb_class;

        public int usb_subclass;

        public int usb_protocol;

        [NativeTypeName("char[1024]")]
        public fixed sbyte library[1024];

        [NativeTypeName("char[1024]")]
        public fixed sbyte id[1024];

        public GphotoDeviceType device_type;

        public int reserved2;

        public int reserved3;

        public int reserved4;

        public int reserved5;

        public int reserved6;

        public int reserved7;

        public int reserved8;
    }
}

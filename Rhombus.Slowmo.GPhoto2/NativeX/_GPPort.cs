namespace Rhombus.Slowmo.GPhoto2.NativeX
{
    public unsafe partial struct _GPPort
    {
        public GPPortType type;

        [NativeTypeName("GPPortSettings")]
        public _GPPortSettings settings;

        [NativeTypeName("GPPortSettings")]
        public _GPPortSettings settings_pending;

        public int timeout;

        [NativeTypeName("GPPortPrivateLibrary *")]
        public _GPPortPrivateLibrary* pl;

        [NativeTypeName("GPPortPrivateCore *")]
        public _GPPortPrivateCore* pc;
    }
}

using System.Runtime.InteropServices;

namespace Rhombus.Slowmo.Nikon;

public static class BufferExtensions {
    //public static unsafe T As<T>(this byte[] buffer) {

    //    T s;
    //    fixed (byte* parr = buffer) {
    //        s = *((T*)parr);
    //    }
    //    return s;
    //}
    //public static unsafe T As<T>(this byte[] bytes) where T : struct {
    //    fixed (byte* ptr = &bytes[0]) {
    //        return Marshal.PtrToStructure<T>((IntPtr)ptr);
    //    }
    //}

    public static T As<T>(this byte[] bytes) where T : struct {
        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        try {
            return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
        }
        finally {
            handle.Free();
        }
    }
}
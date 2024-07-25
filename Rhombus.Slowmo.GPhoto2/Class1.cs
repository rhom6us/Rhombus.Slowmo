using Rhombus.Slowmo.GPhoto2.NativeX;
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace Rhombus.Slowmo.GPhoto2;

public class Class1 {
    public void asdf() {
        unsafe {
            var cam = Camera.Create();
            if(cam.Abilities.file_operations.HasFlag(CameraFileOperation.GP_FILE_OPERATION_RAW)) {
                // hoorah!
            }
            
        }
    }
}

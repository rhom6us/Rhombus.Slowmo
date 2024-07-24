using Rhombus.Slowmo.GPhoto2.Native;
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace Rhombus.Slowmo.GPhoto2;

public class Class1 {
    public void asdf() {
        unsafe {
            _Camera* camera;
            Native.Methods.gp_camera_new(&camera);
        }
    }
}

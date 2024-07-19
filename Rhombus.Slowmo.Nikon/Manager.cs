using System.Diagnostics.CodeAnalysis;
using Nikon;

namespace Rhombus.Slowmo.Nikon;

public class Manager : IDisposable {
    private readonly NikonManager _manager;
    private readonly TaskCompletionSource<Camera> _tcs = new ();

    public Manager(): this(Directory.EnumerateFiles(Environment.CurrentDirectory, "*.md3", SearchOption.TopDirectoryOnly).Single()) { }

    public Manager(string md3File) {

        _manager = new NikonManager("Type0009.md3");
        _manager.DeviceAdded +=ManagerOnDeviceAdded;
        //_manager.DeviceAdded += (sender, device) => {
            
        //};
    }

    private void ManagerOnDeviceAdded(NikonManager sender, NikonDevice device) {
        _tcs.SetResult(new(device));
    }

    [return: NotNull]
    public Task<Camera> GetCamera() {
        //var manager = new NikonManager("Type0009.md3");
        // Listen for the 'DeviceAdded' event
        

        return _tcs.Task;
    }

    #region IDisposable

    /// <inheritdoc />
    public void Dispose() {
        _manager.Shutdown();
    }

    #endregion
}
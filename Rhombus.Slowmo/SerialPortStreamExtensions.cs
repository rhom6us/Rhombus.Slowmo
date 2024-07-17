namespace Rhombus.Slowmo;
using RJCP.IO.Ports;

internal static class SerialPortStreamExtensions {
    public static Task<string> ReadLineAsync(this SerialPortStream port) {
        var tcs = new TaskCompletionSource<string>();
        _ = Task.Run(() => {
            try {
                tcs.SetResult(port.ReadLine());
            }
            catch (Exception ex) {
                tcs.SetException(ex);
            }
        });
        return tcs.Task;
    }
}
namespace Rhombus.Slowmo.Stepper;

internal static class AsyncExtensions {
    public static System.Runtime.CompilerServices.TaskAwaiter GetAwaiter(this System.Threading.CancellationToken cancellationToken) {
        if (cancellationToken.IsCancellationRequested) {
            return System.Threading.Tasks.Task.CompletedTask.GetAwaiter();
        }
        var tcs = new System.Threading.Tasks.TaskCompletionSource();
        _ = cancellationToken.Register(tcs.SetResult);
        return tcs.Task.GetAwaiter();
    }
    public static System.Runtime.CompilerServices.TaskAwaiter GetAwaiter(this System.TimeSpan timeSpan) => System.Threading.Tasks.Task.Delay(timeSpan).GetAwaiter();
}
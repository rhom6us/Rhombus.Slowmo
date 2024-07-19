namespace Rhombus.Slowmo;
using RJCP.IO.Ports;

public class Stepper : IDisposable, IAsyncDisposable {
    private readonly SerialPortStream _port;
    public Stepper(int baud = 115200) : this(SerialPortStream.GetPortNames().Single(), baud) { }
    public Stepper(string port, int baud = 115200) : this(new SerialPortStream(port, baud)) { }

    public Stepper(SerialPortStream port) {
        _port = port;
        if (!port.IsOpen) {
            port.Open();
        }
    }



    private async Task SendMessage(char command, long µSteps) {
        _port.Write($"{command.ToString().ToLower()}{µSteps}");
        _ = await _port.ReadLineAsync();
    }

    private async Task SendMessage(char command, TimeSpan time) {
        _port.Write($"{command.ToString().ToUpper()}{time.TotalHours:0.0####}");
        _ = await _port.ReadLineAsync();
    }

    private async Task<long> GetSteps(char command) {
        _port.Write($"{command.ToString().ToLower()}");
        return long.Parse(await _port.ReadLineAsync());
    }

    private async Task<TimeSpan> GetTime(char command) {
        _port.Write($"{command.ToString().ToUpper()}");
        return TimeSpan.FromHours(double.Parse(await _port.ReadLineAsync()));
    }

    public Task<TimeSpan> GetPosition() => this.GetTime('N');

    public Task<TimeSpan> GetRemaining() => this.GetTime('R');

    public Task SetPosition(long µSteps) => this.SendMessage('p', µSteps);

    public Task SetPosition(TimeSpan time) => this.SendMessage('P', time);

    public Task MoveTo(long µSteps) => this.SendMessage('t', µSteps);

    public Task MoveTo(TimeSpan time) => this.SendMessage('T', time);

    public Task Move(long µSteps) => this.SendMessage('m', µSteps);

    public Task Move(TimeSpan time) => this.SendMessage('M', time);

    public Task SetMaxSpeed(long µSteps) => this.SendMessage('s', µSteps);

    public Task SetMaxSpeed(TimeSpan time) => this.SendMessage('S', time);

    public Task SetAcceleration(long µSteps) => this.SendMessage('a', µSteps);

    public Task SetAcceleration(TimeSpan time) => this.SendMessage('A', time);

    #region IDisposable

    protected virtual void Dispose(bool disposing) {
        if (disposing) {
            _port.Dispose();
        }
    }

    /// <inheritdoc />
    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual async ValueTask DisposeAsyncCore() {
        await _port.DisposeAsync();
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync() {
        await DisposeAsyncCore();
        GC.SuppressFinalize(this);
    }

    #endregion
}
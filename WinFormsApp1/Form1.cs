namespace WinFormsApp1;
using System.IO.Ports;
using Iot.Device.Arduino;
using Rhombus.Slowmo.Firmata;

public partial class Form1 : Form {
    private ArduinoBoard? _board;
    private AccelStepper? _handler;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e) {
        _board = new ArduinoBoard(SerialPort.GetPortNames().Single(), 115200);
        _handler = new AccelStepper();
        _ = _board.FirmwareName;
        _board.AddCommandHandler(_handler);
        _handler.Configure(0, AccelStepperInterface.Driver, 3, false, 25, 33);
        _handler.SetSpeed(0, 10000);
        _handler.SetAcceleration(0, 250);
    }

    private void Button1_Click(object sender, EventArgs e) => textBox1.Text = _handler?.ReportPosition(0).ToString();

    private void TextBox1_TextChanged(object sender, EventArgs e) {
    }

    private void Button4_Click(object sender, EventArgs e) => _handler?.Stop(0);

    private void Button2_Click(object sender, EventArgs e) => _handler?.Step(0, (int)numericUpDown1.Value);

    private void Button3_Click(object sender, EventArgs e) => _handler?.To(0, (int)numericUpDown2.Value);
}
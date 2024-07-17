namespace WinFormsApp1;
using Iot.Device.Arduino;
using Rhombus.Slowmo;

public partial class Form1 : Form {
    private ArduinoBoard board;
    private AccelStepper handler;
    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e) {
        board = new Iot.Device.Arduino.ArduinoBoard(System.IO.Ports.SerialPort.GetPortNames().Single(), 115200);
        handler = new Rhombus.Slowmo.AccelStepper();
        _ = board.FirmwareName;
        board.AddCommandHandler(handler);
        handler.Configure(0, AccelStepperInterface.Driver, 3, false, 25, 33);
        handler.SetSpeed(0, 10000);
        handler.SetAcceleration(0, 250);
    }

    private void Button1_Click(object sender, EventArgs e) => textBox1.Text = handler.ReportPosition(0).ToString();

    private void TextBox1_TextChanged(object sender, EventArgs e) {

    }

    private void Button4_Click(object sender, EventArgs e) => handler.Stop(0);

    private void Button2_Click(object sender, EventArgs e) => handler.Step(0, (int)numericUpDown1.Value);

    private void Button3_Click(object sender, EventArgs e) => handler.To(0, (int)numericUpDown2.Value);
}

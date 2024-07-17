namespace Rhombus.Slowmo.Firmata;
using System;
using Iot.Device.Arduino;

/// <summary>
/// https://github.com/firmata/protocol/blob/master/accelStepperFirmata.md
/// </summary>
public class AccelStepper() : ExtendedCommandHandler(SupportedMode.Stepper) {
    /// <param name="stepSize">Step size is 0.5^stepSize (e.g. 0=whole-step, 1=half-step, 2=quarter-step, 3=eighth-step, etc) </param>
    public void Configure(byte deviceNumber, AccelStepperInterface stepperInterface, byte stepSize, bool hasEnablePin, byte motor1OrStepPin, byte motor2OrDirectionPin, byte? motor3Pin = null, byte? motor4Pin = null, byte? enablePin = null, byte? invertMask = null) {
        if (deviceNumber >= 10) {
            throw new ArgumentOutOfRangeException(nameof(deviceNumber));
        }
        if (stepSize > 0b111) {
            throw new ArgumentOutOfRangeException(nameof(stepSize));
        }
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.Config);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.WriteByte((byte)((byte)stepperInterface | (stepSize << 1) | (hasEnablePin ? 1 : 0)));
        commandSequence.WriteByte(motor1OrStepPin);
        commandSequence.WriteByte(motor2OrDirectionPin);
        if (stepperInterface >= AccelStepperInterface.ThreeWire) {
            commandSequence.WriteByte(motor3Pin ?? throw new ArgumentNullException(nameof(motor3Pin)));
        }
        if (stepperInterface >= AccelStepperInterface.FourWire) {
            commandSequence.WriteByte(motor4Pin ?? throw new ArgumentNullException(nameof(motor4Pin)));
        }
        if (hasEnablePin) {
            commandSequence.WriteByte(enablePin ?? throw new ArgumentNullException(nameof(enablePin)));
        }

        if (invertMask is not null) {
            commandSequence.WriteByte(invertMask.Value);
        }
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }


    public void Zero(int deviceNumber) {

        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.Zero);
        commandSequence.WriteByte((byte)deviceNumber);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }

    public void Step(byte deviceNumber, int relativePosition) {
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.Step);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.SendInt32(relativePosition);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }
    public void To(byte deviceNumber, int absolutePosition) {
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.To);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.SendInt32(absolutePosition);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }
    public void Enable(int deviceNumber, bool enabled = true) {

        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.Enable);
        commandSequence.WriteByte((byte)deviceNumber);
        commandSequence.WriteByte((byte)(enabled ? 1 : 0));
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }

    /// <returns>The position</returns>
    public int Stop(byte deviceNumber) {

        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.Stop);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        var reply = this.SendCommandAndWait(commandSequence);

        return reply[0] != (byte)AccelStepperCommand.ReportPosition
            ? throw new InvalidOperationException("Did not receive the correct response")
            : FirmataCommandSequence.DecodeInt32(reply, 4);

    }


    /// Send position data when it's requested or a move completes
    /// <returns>The position</returns>
    public int ReportPosition(byte deviceNumber) {

        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.ReportPosition);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        var reply = this.SendCommandAndWait(commandSequence);

        return reply[0] != (byte)FirmataSysexCommand.ACCELSTEPPER_DATA ||
                reply[1] != (byte)AccelStepperCommand.ReportPosition
            ? throw new InvalidOperationException("Did not receive the correct response")
            : FirmataCommandSequence.DecodeInt32(reply, 2);

    }

    /// <param name="value">steps/sec^2</param>
    public void SetAcceleration(byte deviceNumber, double value) {
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.SetAcceleration);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.WriteCustomFloat(value);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }

    /// <param name="value">steps/sec^2</param>
    public void SetSpeed(byte deviceNumber, double value) {
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.SetSpeed);
        commandSequence.WriteByte(deviceNumber);
        commandSequence.WriteCustomFloat(value);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }

    public void MultiConfig(byte groupNumber, params byte[] deviceNumbers) {
        if (deviceNumbers.Length is < 2 or > 10) {
            throw new ArgumentOutOfRangeException(nameof(deviceNumbers));
        }
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.MultiConfig);
        commandSequence.WriteByte(groupNumber);
        foreach (var deviceNumber in deviceNumbers) {
            commandSequence.WriteByte(deviceNumber);
        }
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }

    public void MultiTo(byte groupNumber, int relativePosition) {
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.MultiTo);
        commandSequence.WriteByte(groupNumber);
        //foreach (var deviceNumber in deviceNumbers) {
        //    commandSequence.SendInt32(relativePosition);
        //}
        throw new NotImplementedException();
        //commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        //this.SendCommand(commandSequence);
    }
    public void MultiStop(byte groupNumber) {

        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.ACCELSTEPPER_DATA);
        commandSequence.WriteByte((byte)AccelStepperCommand.MultiStop);
        commandSequence.WriteByte(groupNumber);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);

    }
}
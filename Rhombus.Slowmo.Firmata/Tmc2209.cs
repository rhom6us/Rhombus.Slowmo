namespace Rhombus.Slowmo;
using System;
using Iot.Device.Arduino;

public class Tmc2209() : ExtendedCommandHandler(new SupportedMode(0xa0, "TMC2209")) {
    //public  event  Action<byte>InterstepDuration_Receive { add; remove; }
    private static FirmataCommandSequence StartSequence(Tmc2209Command command) {
        var commandSequence = new FirmataCommandSequence();
        commandSequence.WriteByte((byte)FirmataSysexCommand.TMC2209_DATA);
        commandSequence.WriteByte((byte)command);

        return commandSequence;
    }

    private void SimpleMessage(Tmc2209Command command, params byte[] data) {
        var commandSequence = StartSequence(command);
        commandSequence.Write(data);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }
    private void SimpleMessage(Tmc2209Command command, uint data) {
        var commandSequence = StartSequence(command);
        commandSequence.SendUInt32(data);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }
    private void SimpleMessage(Tmc2209Command command, int data) {
        var commandSequence = StartSequence(command);
        commandSequence.SendInt32(data);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }
    private void SimpleMessage(Tmc2209Command command, short data) {
        var commandSequence = StartSequence(command);
        commandSequence.SendInt14(data);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }

    #region unidirectional methods
    public enum SerialAddress : byte {
        SerialAddress0=0,
        SerialAddress1=1,
        SerialAddress2=2,
        SerialAddress3=3,
    };
    public void Setup(long serialBaudRate, SerialAddress serialAddress) {
        var commandSequence = StartSequence(Tmc2209Command.Setup);
        commandSequence.WriteByte((byte)serialAddress);
        commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
        this.SendCommand(commandSequence);
    }
    //public void Setup(long serialBaudRate, SerialAddress serialAddress, short alternateRxPin, short alternateTxPin) {
    //    var commandSequence = this.StartSequence(Tmc2209Command.Setup);
    //    commandSequence.WriteByte((byte)serialAddress);
    //    commandSequence.SendInt14(alternateRxPin);
    //    commandSequence.SendInt14(alternateTxPin);
    //    commandSequence.WriteByte(FirmataCommandSequence.EndSysex);
    //    this.SendCommand(commandSequence);
    //}

    /// <summary>
    /// driver must be enabled before use it is disabled by default
    /// </summary>
    /// <param name="hardwareEnablePin"></param>
    public void SetHardwareEnablePin(byte hardwareEnablePin) => this.SimpleMessage(Tmc2209Command.SetHardwareEnablePin, hardwareEnablePin);

    public void Enable() => this.SimpleMessage(Tmc2209Command.Enable);

    public void Disable() => this.SimpleMessage(Tmc2209Command.Disable);

    /// <param name="microstepsPerStep">valid values = 1,2,4,8,...128,256, other values get rounded down</param>
    public void SetMicrostepsPerStep(ushort microstepsPerStep) => this.SimpleMessage(Tmc2209Command.SetMicrostepsPerStep, microstepsPerStep);


    /// <param name="exponent">valid values = 0-8, microsteps = 2^exponent, 0=1,1=2,2=4,...8=256</param>
    /// https://en.wikipedia.org/wiki/Power_of_two
    public void SetMicrostepsPerStepPowerOfTwo(byte exponent) => this.SimpleMessage(Tmc2209Command.SetMicrostepsPerStepPowerOfTwo, exponent);


    /// <param name="percent">range 0-100</param>
    public void SetRunCurrent(byte percent) => this.SimpleMessage(Tmc2209Command.SetRunCurrent, percent);

    /// <param name="percent">range 0-100</param>
    public void SetHoldCurrent(byte percent) => this.SimpleMessage(Tmc2209Command.SetHoldCurrent, percent);

    /// <param name="percent">range 0-100</param>
    public void SetHoldDelay(byte percent) => this.SimpleMessage(Tmc2209Command.SetHoldDelay, percent);
    /// <param name="runCurrentPercent">0-100</param>
    /// <param name="holdCurrentPercent">0-100</param>
    /// <param name="holdDelayPercent">0-100</param>
    public void SetAllCurrentValues(byte runCurrentPercent, byte holdCurrentPercent, byte holdDelayPercent) => this.SimpleMessage(Tmc2209Command.SetAllCurrentValues, runCurrentPercent, holdCurrentPercent, holdDelayPercent);


    public void EnableDoubleEdge() => this.SimpleMessage(Tmc2209Command.EnableDoubleEdge);
    public void DisableDoubleEdge() => this.SimpleMessage(Tmc2209Command.DisableDoubleEdge);

    public void EnableInverseMotorDirection() => this.SimpleMessage(Tmc2209Command.EnableInverseMotorDirection);
    public void DisableInverseMotorDirection() => this.SimpleMessage(Tmc2209Command.DisableInverseMotorDirection);

    public enum StandstillMode : byte {
        Normal=0,
        Freewheeling=1,
        StrongBraking=2,
        Braking=3,
    }
    public void SetStandstillMode(StandstillMode mode) => this.SimpleMessage(Tmc2209Command.SetStandstillMode, (byte)mode);

    public void EnableAutomaticCurrentScaling() => this.SimpleMessage(Tmc2209Command.EnableAutomaticCurrentScaling);
    public void DisableAutomaticCurrentScaling() => this.SimpleMessage(Tmc2209Command.DisableAutomaticCurrentScaling);
    public void EnableAutomaticGradientAdaptation() => this.SimpleMessage(Tmc2209Command.EnableAutomaticGradientAdaptation);
    public void DisableAutomaticGradientAdaptation() => this.SimpleMessage(Tmc2209Command.DisableAutomaticGradientAdaptation);

    /// <param name="pwmAmplitude">0-255</param>
    public void SetPwmOffset(byte pwmAmplitude) => this.SimpleMessage(Tmc2209Command.SetPwmOffset, pwmAmplitude);

    /// <param name="pwmAmplitude">0-255</param>
    public void SetPwmGradient(byte pwmAmplitude) => this.SimpleMessage(Tmc2209Command.SetPwmGradient, pwmAmplitude);


    /// <param name="powerDownDelay">minimum of 2 for StealthChop auto-tuning</param>
    public void SetPowerDownDelay(byte powerDownDelay) => this.SimpleMessage(Tmc2209Command.SetPowerDownDelay, powerDownDelay);

    public const byte ReplyDelayMax = 15;
    /// <param name="delay">minimum of 2 when using multiple serial addresses in bidirectional communication</param>
    public void SetReplyDelay(byte delay) => this.SimpleMessage(Tmc2209Command.SetReplyDelay, delay);

    public void MoveAtVelocity(int microstepsPerPeriod) => this.SimpleMessage(Tmc2209Command.MoveAtVelocity, microstepsPerPeriod);

    public void MoveUsingStepDirInterface() => this.SimpleMessage(Tmc2209Command.MoveUsingStepDirInterface);

    public void EnableStealthChop() => this.SimpleMessage(Tmc2209Command.EnableStealthChop);
    public void DisableStealthChop() => this.SimpleMessage(Tmc2209Command.DisableStealthChop);

    public void SetStealthChopDurationThreshold(uint durationThreshold) => this.SimpleMessage(Tmc2209Command.SetStealthChopDurationThreshold, durationThreshold);



    public void SetStallGuardThreshold(byte stallGuardThreshold) => this.SimpleMessage(Tmc2209Command.SetStallGuardThreshold, stallGuardThreshold);


    /// <param name="lowerThreshold">min = 1, max = 15</param>
    /// <param name="upperThreshold"> min = 0, max = 15, 0-2 recommended</param>
    public void EnableCoolStep(byte lowerThreshold = 1, byte upperThreshold = 0) => this.SimpleMessage(Tmc2209Command.EnableCoolStep, lowerThreshold, upperThreshold);
    public void DisableCoolStep() => this.SimpleMessage(Tmc2209Command.DisableCoolStep);
    public enum CurrentIncrement : byte {
        CurrentIncrement1=0,
        CurrentIncrement2=1,
        CurrentIncrement4=2,
        CurrentIncrement8=3,
    }
    public void SetCoolStepCurrentIncrement(CurrentIncrement currentIncrement) => this.SimpleMessage(Tmc2209Command.SetCoolStepCurrentIncrement, (byte)currentIncrement);
    public enum MeasurementCount : byte {
        MeasurementCount32=0,
        MeasurementCount8=1,
        MeasurementCount2=2,
        MeasurementCount1=3,
    }
    public void SetCoolStepMeasurementCount(MeasurementCount measurementCount) => this.SimpleMessage(Tmc2209Command.SetCoolStepMeasurementCount, (byte)measurementCount);
    public void SetCoolStepDurationThreshold(uint durationThreshold) => this.SimpleMessage(Tmc2209Command.SetCoolStepDurationThreshold, durationThreshold);

    public void EnableAnalogCurrentScaling() => this.SimpleMessage(Tmc2209Command.EnableAnalogCurrentScaling);
    public void DisableAnalogCurrentScaling() => this.SimpleMessage(Tmc2209Command.DisableAnalogCurrentScaling);

    public void UseExternalSenseResistors() => this.SimpleMessage(Tmc2209Command.UseExternalSenseResistors);
    public void UseInternalSenseResistors() => this.SimpleMessage(Tmc2209Command.UseInternalSenseResistors);

    #endregion
    #region bidirectional methods

    public byte GetVersion() => throw new NotImplementedException();

    /// <summary>
    /// if driver is not communicating, check power and communication connections
    /// </summary>
    public bool IsCommunicating() => throw new NotImplementedException();

    /// <summary>
    /// check to make sure TMC2209 is properly setup and communicating
    /// </summary>
    public bool IsSetupAndCommunicating() => throw new NotImplementedException();

    /// <summary>
    /// driver may be communicating but not setup if driver power is lost then restored after setup so that defaults are loaded instead of setup options
    /// </summary>
    public bool IsCommunicatingButNotSetup() => throw new NotImplementedException();

    /// <summary>
    /// Driver may also be disabled by the hardware enable input pin. This pin must be grounded or disconnected before driver may be enabled
    /// </summary>
    public bool HardwareDisabled() => throw new NotImplementedException();

    public ushort GetMicrostepsPerStep() => throw new NotImplementedException();

    #endregion

    protected override void OnSysexData(ReplyType type, byte[] data) => base.OnSysexData(type, data);
}

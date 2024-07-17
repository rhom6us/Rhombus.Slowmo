namespace Rhombus.Slowmo.Firmata;

public enum AccelStepperInterface : byte {
    Driver = 0b001_0000,
    TwoWire = 0b010_0000,
    ThreeWire = 0b011_0000,
    FourWire = 0b100_0000
}
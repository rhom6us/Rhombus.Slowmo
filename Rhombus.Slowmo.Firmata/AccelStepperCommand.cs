namespace Rhombus.Slowmo;

public enum AccelStepperCommand : byte
{
    Config = 0x00,
    Zero = 0x01,
    Step = 0x02,
    To = 0x03,
    Enable = 0x04,
    Stop= 0x05,
    ReportPosition= 0x06,
    Limit= 0x07,
    SetAcceleration= 0x08,
    SetSpeed= 0x09,
    MoveComplete= 0x0A,
    MultiConfig= 0x20,
    MultiTo= 0x21,
    MultiStop= 0x23,
    MultiMoveComplete= 0x24,

}
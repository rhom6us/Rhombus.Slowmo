﻿namespace Rhombus.Slowmo.Firmata;

public enum FirmataSysexCommand : byte {
    ACCELSTEPPER_DATA = 0x62,
    TMC2209_DATA = 0xAA,
}
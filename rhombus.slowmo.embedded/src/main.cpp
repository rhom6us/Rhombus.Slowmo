#include <TMC2209.h>
#include <AccelStepper.h>

// #define EN_PIN           12 // Enable
#define DIR_PIN          33//9 // Direction
#define STEP_PIN         25//7 // Step
// #define CS_PIN           42 // Chip select
// #define SW_MOSI          66 // Software Master Out Slave In (MOSI)
// #define SW_MISO          44 // Software Master In Slave Out (MISO)
// #define SW_SCK           64 // Software Slave Clock (SCK)
// #define SW_RX            63 // TMC2208/TMC2224 SoftwareSerial receive pin
// #define SW_TX            40 // TMC2208/TMC2224 SoftwareSerial transmit pin
// #define SERIAL_PORT Serial1 // TMC2208/TMC2224 HardwareSerial port
// #define DRIVER_ADDRESS 0b00 // TMC2209 Driver address according to MS1 and MS2

// #define R_SENSE 0.11f // Match to your driver
#define STEP_DIV 8
AccelStepper stepper(AccelStepper::DRIVER, STEP_PIN, DIR_PIN);

// enum class TMC_STEP_DIV {
//   over8 = 0b00,
//   over32 = 0b01,
//   over64 = 0b10,
//   over16 = 0b11
// };
// HardwareSerial& serial_stream = Serial1;
void do_move(uint8_t hour) {
  auto pct = -hour / 12.0;
  auto step = pct * 200;
  auto ustep = step * STEP_DIV;
  stepper.moveTo(ustep);
}
// const long SERIAL_BAUD_RATE = 115200;
// const int DELAY = 2000;
// const int32_t VELOCITY = 10000;
// const uint8_t PERCENT_MIN = 0;
// // current values may need to be reduced to prevent overheating depending on
// // specific motor and power supply voltage
// const uint8_t PERCENT_MAX = 100;
// const uint8_t PERCENT_INC = 10;

// uint8_t run_current_percent = PERCENT_INC;

// const uint8_t STALL_GUARD_THRESHOLD = 50;


// Instantiate TMC2209
// TMC2209 stepper_driver;

// void setup() {
//   Serial.begin(SERIAL_BAUD_RATE);
//   while (!Serial);
//   Serial.println("hiyya");
//   Serial1.begin(SERIAL_BAUD_RATE);
//   stepper_driver.setup(serial_stream);

//   stepper_driver.enable();
//   stepper_driver.moveAtVelocity(VELOCITY);
//   Serial.println("es");
// }

// void loop() {
//   // Serial.println("loop");
//   if (not stepper_driver.isSetupAndCommunicating()) {
//     Serial.println(!!Serial1);
//     Serial.println("Stepper driver not setup and communicating!");
//     return;
//   }

//   Serial.print("setRunCurrent(");
//   Serial.print(run_current_percent);
//   Serial.println(")");
//   stepper_driver.setRunCurrent(run_current_percent);
//   delay(DELAY);

//   TMC2209::Status status = stepper_driver.getStatus();
//   Serial.print("status.current_scaling = ");
//   Serial.println(status.current_scaling);
//   Serial.println();

//   if (run_current_percent == PERCENT_MAX) {
//     run_current_percent = PERCENT_MIN;
//   }
//   run_current_percent += PERCENT_INC;
// }

void setup()
{
  // pinMode(EN_PIN, OUTPUT);
  // digitalWrite(EN_PIN, LOW);
  // Serial.begin(115200);
  // while (Serial) {
  //   delay(100);
  // }
  // Serial.println("heyyo");
  // stepper_driver.setup(Serial1);
  // Serial.println("mmkay");

  // // stepper_driver.setMicrostepsPerStep(32); //200, 1.8 deg
  // stepper_driver.setMicrostepsPerStepPowerOfTwo(0);
  // stepper_driver.setRunCurrent(100);

  // stepper_driver.setHoldCurrent(50);
  // // stepper_driver.enableCoolStep();
  // // stepper_driver.setStallGuardThreshold(STALL_GUARD_THRESHOLD);
  // stepper_driver.enable();

  Serial.println("kkkkkkkkkkkk");
  // stepper_driver.setStandstillMode(stepper_driver.NORMAL);
  stepper.enableOutputs();
  stepper.setMaxSpeed(10000);
  stepper.setAcceleration(250);
  stepper.setCurrentPosition(0);
  // stepper.moveTo(5000);
}

// // void tune_stallguard()
// // {
// //   if (not stepper_driver.isSetupAndCommunicating())
// //   {
// //     Serial.println("Stepper driver not setup and communicating!");
// //     return;
// //   }

// //   // Serial.print("run_current_percent = ");
// //   // Serial.println(RUN_CURRENT_PERCENT);

// //   // Serial.print("stall_guard_threshold = ");
// //   // Serial.println(STALL_GUARD_THRESHOLD);

// //   Serial.println("now slowly stall the motor");
// //   // higher value means less load
// //   // uint16_t load_headroom = stepper_driver.getStallGuardResult();
// //   uint16_t max_load_headroom;
// //   do {
// //     max_load_headroom = stepper_driver.getStallGuardResult();
// //   } while (!stepper_driver.isDiagTripped());

// //   auto new_threshold = max_load_headroom / 2 + 1;
// //   stepper_driver.setStallGuardThreshold(new_threshold);
// //   Serial.print("stall_guard_result = ");
// //   Serial.println(max_load_headroom);

// //   Serial.println();
// //   delay(DELAY);

// // }

// // const int32_t VELOCITY = 20000;
uint8_t hour = 0;
auto stamp = millis();
void loop() {
  // Serial.println(digitalRead(STEP_PIN));
  // digitalWrite(STEP_PIN, !digitalRead(STEP_PIN));
  // // delay(10);
  // delay(1000);

  // stepper_driver.moveAtVelocity(VELOCITY);
  // delay(1000);
  // stepper_driver.moveAtVelocity(0);
      // If at the end of travel go to the other end
  auto now = millis();
  if (now - stamp >= 3000) {
    // hour++;
    hour = (hour + 1) % 12;
    stamp = now;
    do_move(hour);

  }
  // stepper.moveTo(5000*hour);
  // do_move(hour);
  // printf("%d, ", (int)stepper.distanceToGo());
  // if (stepper.distanceToGo() == 0) {
  //   stepper.moveTo(-stepper.currentPosition());
  //   printf("\n");
  // }

  stepper.run();
}
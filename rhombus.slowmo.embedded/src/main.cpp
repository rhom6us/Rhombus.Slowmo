#include <Arduino.h>
#include <TMC2209.h>
#include <AccelStepper.h>

#define EN_PIN           A5
#define STEP_PIN         A2
#define DIR_PIN          A3

#define STEP_DIV 8
#define TOTAL_STEPS 200
#define TOTAL_USTEPS (TOTAL_STEPS*STEP_DIV)
#define HOUR_TO_USTEPS(hour) static_cast<long>((hour / 12.f) * TOTAL_USTEPS)
#define USTEPS_TO_HOUR(usteps) (usteps * 12.f / TOTAL_USTEPS)
AccelStepper stepper(AccelStepper::DRIVER, STEP_PIN, DIR_PIN);



void setup()
{
  pinMode(EN_PIN, OUTPUT);
  digitalWrite(EN_PIN, HIGH);
  Serial.begin(115200);
  while (!Serial);
  stepper.enableOutputs();
  stepper.setMaxSpeed(10000);
  stepper.setAcceleration(250);
  stepper.setCurrentPosition(0);
  digitalWrite(EN_PIN, LOW);
}

void wait_movement() {
  auto left = stepper.distanceToGo();
  while (left > 0) {
    // Serial.print(left);
    // Serial.print('\n');
    stepper.run();
    left = stepper.distanceToGo();
  }
  // Serial.print(0);
  Serial.print('\n');
  Serial.flush();
}

void loop() {
  // stepper.run();
  if (!Serial.available()) {
    return;
  }

  char command = Serial.read();

  switch (command) {

    /******* MOVE RELATIVE (m) *******/
    case 'm':
      stepper.move(Serial.parseInt());
      wait_movement();
      break;
    case 'M':
      stepper.move(HOUR_TO_USTEPS(Serial.parseFloat()));
      wait_movement();
      break;

      /******* MOVE ABSOLUTE (t) *******/
    case 't':
      stepper.moveTo(Serial.parseInt());
      wait_movement();
      break;
    case 'T':
      stepper.moveTo(HOUR_TO_USTEPS(Serial.parseFloat()));
      wait_movement();
      break;

      /******* SET SPEED (s) *******/
    case 's':
      stepper.setMaxSpeed(Serial.parseInt());
      Serial.println();
      break;
    case 'S':
      stepper.setMaxSpeed(HOUR_TO_USTEPS(Serial.parseFloat()));
      Serial.println();
      break;

      /******* SET ACCELERATION (a) *******/
    case 'a':
      stepper.setAcceleration(Serial.parseInt());
      Serial.println();
      break;
    case 'A':
      stepper.setAcceleration(HOUR_TO_USTEPS(Serial.parseFloat()));
      Serial.println();
      break;

      /******* SET POSITION (p) *******/
    case 'p':
      stepper.setCurrentPosition(Serial.parseInt());
      Serial.println();
      break;
    case 'P':
      stepper.setCurrentPosition(HOUR_TO_USTEPS(Serial.parseFloat()));
      Serial.println();
      break;

      /******* GET POSITION (n) *******/
    case 'n': //report raw position
      Serial.println(stepper.currentPosition());
      break;
    case 'N': //report hour position
      Serial.println(USTEPS_TO_HOUR(stepper.currentPosition()));
      break;

      /******* GET REMAINING (r) *******/
    case 'r':
      Serial.println(stepper.distanceToGo());
      break;
    case 'R':
      Serial.println(USTEPS_TO_HOUR(stepper.distanceToGo()));
      break;


      /**********************************/
    default:
      Serial.print("wtf mate");
      break;
  }


}
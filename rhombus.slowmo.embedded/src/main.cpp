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


void loop() {
  stepper.run();
  if (!Serial.available()) {
    return;
  }

  char command = Serial.read();

  switch (command) {

    case 'm': //raw position
      stepper.move(Serial.parseInt());
      break;
    case 'M': // hour position
      stepper.move(HOUR_TO_USTEPS(Serial.parseFloat()));
      break;

    case 't': //raw position
      stepper.moveTo(Serial.parseInt());
      break;
    case 'T': // hour position
      stepper.moveTo(HOUR_TO_USTEPS(Serial.parseFloat()));
      break;

    case 's': // speed
      stepper.setMaxSpeed(Serial.parseInt());
      break;
    case 'S': // speed in hours
      stepper.setMaxSpeed(HOUR_TO_USTEPS(Serial.parseFloat()));
      break;

    case 'a': // acceleration
      stepper.setAcceleration(Serial.parseInt());
      break;
    case 'A': // acceleration in hours
      stepper.setAcceleration(HOUR_TO_USTEPS(Serial.parseFloat()));
      break;

    case 'z':
      stepper.setCurrentPosition(Serial.parseInt());
      break;
    case 'Z':
      stepper.setCurrentPosition(HOUR_TO_USTEPS(Serial.parseFloat()));
      break;

    case 'p': //report raw position
      Serial.println(stepper.currentPosition());
      break;
    case 'P': //report hour position
      Serial.println(-USTEPS_TO_HOUR(stepper.currentPosition()));
      break;

    case 'r': //report raw remaining
      Serial.println(stepper.distanceToGo());
      break;
    case 'R': //report hour remaining
      Serial.println(USTEPS_TO_HOUR(stepper.distanceToGo()));
      break;

    default:
      Serial.print("wtf mate");
      break;
  }

}
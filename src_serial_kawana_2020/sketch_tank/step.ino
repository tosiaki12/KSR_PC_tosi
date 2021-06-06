/*
 * MotorKnob
 *
 * A stepper motor follows the turns of a potentiometer
 * (or other sensor) on analog input 0.
 *
 * http://www.arduino.cc/en/Reference/Stepper
 * This example code is in the public domain.
 */


/*
 * MotorKnob
 *
 * A stepper motor follows the turns of a potentiometer
 * (or other sensor) on analog input 0.
 *
 * http://www.arduino.cc/en/Reference/Stepper
 * This example code is in the public domain.
 */

#include <Stepper.h>

// change this to the number of steps on your motor
//#define STEPS 100
int STEPS = 100;

// create an instance of the stepper class, specifying
// the number of steps of the motor and the pins it's
// attached to
Stepper stepper(STEPS, 4, 5, 6, 7);

// the previous reading from the analog input
int previous = 0;

void setup_step() {
  // set the speed of the motor to 30 RPMs
  stepper.setSpeed(200);
}

void loop_step() {
  // get the sensor value

  // move a number of steps equal to the change in the
  // sensor reading
  stepper.step(/*previous + */10);

  // remember the previous value of the sensor
  //previous = val;
}




 

/*

#include <Stepper.h>

// change this to the number of steps on your motor
//#define STEPS 100
int STEPS = 100;

// create an instance of the stepper class, specifying
// the number of steps of the motor and the pins it's
// attached to
Stepper stepper(STEPS, 4, 5, 6, 7);

// the previous reading from the analog input
int previous = 0;

void setup() {
  // set the speed of the motor to 30 RPMs
  stepper.setSpeed(200);
}

void loop() {
  // get the sensor value
  int val = analogRead(0);

  // move a number of steps equal to the change in the
  // sensor reading
  stepper.step(previous + 40);

  // remember the previous value of the sensor
  //previous = val;
}


*/

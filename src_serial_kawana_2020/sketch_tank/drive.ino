//モーターの駆動関係
const int PMM = 10;
const int PMH = 9;
const int PMU = 8;

void setup_drive() {
}

void loop_drive() {
}

void com_drive(char pal) {
  runMotor(pal);
}


void runMotor(char pal) {
  runLED(13, 100);
  switch (pal) {
    case 'f':
      digitalWrite(PMU, LOW);
      digitalWrite(PMM, HIGH);
      digitalWrite(PMH, HIGH);
      break;
    case 'm':
      digitalWrite(PMH, LOW);
      digitalWrite(PMU, LOW);
      digitalWrite(PMM, HIGH);
      break;
    case 'h':
      digitalWrite(PMM, LOW);
      digitalWrite(PMU, LOW);
      digitalWrite(PMH, HIGH);
      break;
    case 'u':
      digitalWrite(PMM, LOW);
      digitalWrite(PMH, LOW);
      digitalWrite(PMU, HIGH);
      break;
    case 's':
      digitalWrite(PMM, LOW);
      digitalWrite(PMH, LOW);
      digitalWrite(PMU, LOW);
  }
}

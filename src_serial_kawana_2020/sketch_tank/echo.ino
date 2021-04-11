//超音波センサー関係

const int PUL = 3;//超音波送信
const int PRS = 2;//超音波受信

int intdis = 0;//距離の整数表示


double duration = 0;//超音波の往復にかかる時間
double distance = 0;

bool isEcho = false;//loop毎の測距をするか
bool isEchoCount = false;//二回に一回実行

void setup_echo() {
  pinMode(PRS, INPUT);//echo
  pinMode(PUL, OUTPUT);//trig
}

void loop_echo() {
  if (isEcho == true) {
    if (isEchoCount = false) isEchoCount = true;
    if (isEchoCount = true)  {
      runEcho();
      isEchoCount = false;
    }
  }
}

void com_echo(char pal) {
  switch (pal) {
    case 'b':
      isEcho = true;
      break;
    case 'e':
      isEcho = false;
      break;
  }
}

//呼ぶと一回測距
int runEcho() {

  //第16回 Arduinoでパーツやセンサを使ってみよう～超音波モジュール編
  //https://deviceplus.jp/hobby/entry016/
  digitalWrite(PUL, LOW);
  delayMicroseconds(2);
  digitalWrite(PUL, HIGH);
  delayMicroseconds(10);
  digitalWrite(PUL, LOW);
  duration = pulseIn(PRS, HIGH);
  if (duration > 0) {
    duration = duration / 2;
    distance = duration * 340 * 100 / 1000000;
    intdis = floor(distance);
    if (intdis > 800) {
      Serial.println("OOR");
    } else {
      Serial.println("dis:" + String(intdis) + "cm");
    }
    Serial.flush();
  }
  delay(50);
  return intdis;
}

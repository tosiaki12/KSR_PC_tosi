//Serial_kawana_2020
//シリアル通信
/*
   受信の判定
   一命令ごとに<>区切り　命令ごとの改行も対応
   命令の作成はパソコン側　arduinoは読むだけ
   命令以外は一文字ずつ送信
   基本一受信一命令
   複数の命令は一つずつ区切って送信

   送信
   すべて最後には改行

   loopでデータがあるか判定
   あればstringにして命令かどうか判定
   命令ならmeireiRead()
   命令以外は一文字ずつループしながら読む

   2022年10月8日 gitテスト

*/

//追加テスト
//#include <string.h>

const byte commonVir = 1;

bool isStop = false;//何かあったらtrue　falseになるまで処理しない//作業中

double duration = 0;
double distance = 0;
bool isEchoCont = false;
bool loopcount = false;
String data;

const int PMM = 10;
const int PMH = 9;
const int PMU = 8;

//以下ループごとに更新
int stickX = 0;//ジョイスティックX座標(0~1023)
int stickY = 0;//未使用
int oldstkX = 0;//前回のスティック座標　変化させないときに使う 未使用
int oldstkY = 0;//
short oldservo = 0;//前回のサーボモータの値

void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  Serial.setTimeout(1000);//初期値1000ms
  delay(500);
  pinMode(2, INPUT);//echo
  pinMode(3, OUTPUT);//trig
}

void loop() {
  delay(20);
  if (loopcount) {
    loopcount = false;
  } else {
    loopcount = true;
  }
//-------------------------------------------------------------------------
  if (Serial.available() > 0) {//データが存在する
    int d = Serial.read();
    if (d == 60) {
      data = Serial.readStringUntil('>');//<で始まり>で終わる
      Serial.println("recC->" + data);
      Serial.flush();//送信が終わるまで待つ
      meireiRead(data);
    } else {
      Serial.print("recT->");
      Serial.println(d, HEX);
      Serial.flush();
    }
  }
//-------------------------------------------------------------------------




//-------------------------------------------------------------------------
  data = "N";
  if (loopcount) {
    runEcho('n');//ループ二回に一回だけecho

    stickRead();
    analogWriteTest((stickX / 100)*2 + 32);
    
    int r;
    r = analogRead(4);
    r = map(r,0,1024,0,20);
    Serial.println(r);
    //analogWriteTest(r + 32);
    
  }

}

void meireiRead(String com) {
  String command;
  char t;
  bool isFincom = false;//空白か
  for (char a : com) {
    if (a != ' ' && isFincom == false) {//命令文字なら
      command += a;
    } else if (a == ' ') {
      isFincom = true;
      continue;
    }
    if (isFincom == true) t = a;
  }
  if (command.compareTo("poff") == 0) {
    for (int i = 0; i < 14; i++) {
      digitalWrite(i, LOW); //作業中
    }
  }
  Serial.println("com:" + command);
  Serial.println("pal:" + String(t));
  //Serial.println("pal:" + t);//これをやると送信できない　DECをつけても無理 文字列が詰まる
  Serial.flush();

  if (command.compareTo("test") == 0) {//比較
    Serial.println("cvir:" + commonVir);
  }


  
  if (command.compareTo("run") == 0) runMotor(t);
  if (command.compareTo("echo") == 0) runEcho(t);
  if (command.compareTo("angt") == 0) analogWriteTest(t);




}


void stickRead(){//ジョイスティック
  stickX = analogRead(5);

  
  

}

void analogWriteTest(char t){//1104作成//数値を文字として入力

  t = t - 32;//1~20
  int i = t;
  //Serial.println(i);
  if(/*t >= 9 && t <= 11*/ t == 10){
    oldservo = 10;
    return;//中央の場合変化させない
  }
  if(t == oldservo) return;
  int tm = t*100;//1~20
  int imm = 20000 - tm;
  bool isr = true;


  pinMode(6,OUTPUT);
  /*
  if(isr){
    //analogWrite(7,200);
  }
  if (!(isr)) {
    //digitalWrite(7,LOW);
  }
  */
  for(int i = 0 ; i < 30 ; i++){
    digitalWrite(6,HIGH);
    delayMicroseconds(tm);
    digitalWrite(6,LOW);
    delayMicroseconds(imm);
  }
  oldservo = t;

  
}

void runMotor(char pal) {
  runLED(13, 100);
  switch (pal) {
    case 'f':
      digitalWrite(PMU, LOW);
      digitalWrite(PMM, HIGH);
      digitalWrite(PMH, HIGH);
      analogWriteTest(2);
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
      analogWriteTest(false);
  }
}

void runEcho(char pal) {
  switch (pal) {
    case 'b':
      isEchoCont = true;
      break;
    case 'e':
      isEchoCont = false;
      break;
  }
  if (pal != 'b' and pal != 'e' and isEchoCont) {

    //第16回 Arduinoでパーツやセンサを使ってみよう～超音波モジュール編
    //https://deviceplus.jp/hobby/entry016/
    if (isEchoCont) {
      digitalWrite(3, LOW);
      delayMicroseconds(2);
      digitalWrite(3, HIGH);
      delayMicroseconds(10);
      digitalWrite(3, LOW);
      duration = pulseIn(2, HIGH);
      if (duration > 0) {
        duration = duration / 2;
        distance = duration * 340 * 100 / 1000000;
        int dis = floor(distance);
        if (dis > 800) {
          Serial.println("OOR");
        } else {
          Serial.println("dis:" + String(dis) + "cm");
        }
        Serial.flush();
      }
      delay(50);
    }
  }

}


void runLED(int pin, int msec) {
  digitalWrite(pin, HIGH);
  delay(msec);
  digitalWrite(pin, LOW);
  delay(msec);
}

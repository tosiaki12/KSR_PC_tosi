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

   命令一覧

   test
   通信試験用　バージョンを送信する

   run f/m/h/u/s
   モーターを制御する　パラメータは順に前進、右、左、後退、停止

   ピン一覧
   digital I/O
   08:drive
   09:drive
   10:drive
   
   02:
   03:

*/

//#include <string.h>

const byte commonVir = 0;

bool isStop = false;//何かあったらtrue　falseになるまで処理しない//作業中

String data;

void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  Serial.setTimeout(1000);//初期値1000ms
  delay(500);

  setup_drive();
  setup_echo();

}

void loop() {
  delay(10);

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
  data = "N";
  //-------------------------------------------------------------------------

  loop_drive();
  loop_echo();

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
  chkCommand(command, t);

}

//命令を実行する
void chkCommand(String com, char t) {
  if (com.compareTo("test") == 0) {//比較
    Serial.println("vir: " + String(commonVir));
  }
  Serial.flush();

  if (com.compareTo("run") == 0)  com_drive(t);
  if (com.compareTo("echo") == 0) com_echo(t);



}



void runLED(int pin, int msec) {
  digitalWrite(pin, HIGH);
  delay(msec);
  digitalWrite(pin, LOW);
  delay(msec);
}

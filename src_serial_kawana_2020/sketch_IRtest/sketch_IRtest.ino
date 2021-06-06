#include <IRremote.h>


//https://arduino-irremote.github.io/Arduino-IRremote/index.html (classesに説明あり)
//https://github.com/Arduino-IRremote/Arduino-IRremote/wiki

//http://elm-chan.org/docs/ir_format.html
//https://dora.bk.tsukuba.ac.jp/~takeuchi/?%E9%9B%BB%E6%B0%97%E5%9B%9E%E8%B7%AF%2FArduino%2FUno%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%A6%E8%B5%A4%E5%A4%96%E7%B7%9A%E3%83%AA%E3%83%A2%E3%82%B3%E3%83%B3
//https://omoroya.com/arduino-lesson15/
//https://osoyoo.com/ja/2018/08/29/arduino-lesson-ir-remote-receiver-module-and-controller/
//https://deviceplus.jp/hobby/entry023/
//https://asukiaaa.blogspot.com/2018/05/arduino.html
//https://www.uquest.co.jp/embedded/learning/lecture00.html


/*

   IRRemote関係は最初に設定
   後からほかで使うピンを変更（このライブラリで何のピンが変更されるかわからない）

   (送信中は受信しない）

   受信・送信後には受信を有効化（irrecv.enableIRIn()、irrecv.resume()）
   ピンは必ずプルダウン（プルアップ）
   https://jumbleat.com/2017/10/08/use_ir_remote_lib/
   http://vabenecosi.blog.fc2.com/blog-entry-19.html

*/


#define bdA 9600
#define bdB 115200
#define bdC 500000



void setup() {
  Serial.begin(bdB);
  delay(50);
  Serial.println("start");
  pinMode(7,INPUT);

  irio_setup();
}


void loop() {
  irio_loop();

}

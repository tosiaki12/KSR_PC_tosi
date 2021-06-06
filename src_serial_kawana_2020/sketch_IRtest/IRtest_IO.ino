
//http://cms.db.tokushima-u.ac.jp/DAV/person/S10723/
/*

   https://arduino-irremote.github.io/Arduino-IRremote/index.html (classesに説明あり)


   スケッチ例　SimpleReceiver + SimpleSender

   https://github.com/Arduino-IRremote/Arduino-IRremote/wiki ＊古いらしい


*/

//--------------------------------------------------------------------------------------------------------

//unsigned long time1 = 0;
//unsigned long time2 = 0;

#define IRRPIN 3
#define IRSPIN 4

//受信したとき更新
int radr = 0;
int rcom = 0;
unsigned long rraw = 0;

//送信するとき更新
uint16_t sAddress = 0x0102;
uint8_t sCommand = 0xc4;
uint8_t sRepeats = 0;

IRrecv irrecv(IRRPIN);//ピン
IRsend irsend(IRSPIN);

bool isIRRecving = true;
bool isIRSending = false;

void setIRrecv(bool isrecv) {
  isIRRecving = isrecv;
  if (isrecv) irrecv.enableIRIn();
  if (isrecv == false) irrecv.disableIRIn();
}
void setIsIRSending(bool istrue) {//送信中は受信を切る ここで操作
  isIRSending = istrue;
  setIRrecv(!(istrue));
}
void convIRrecv(){
  setIRrecv(!(isIRRecving));
}

void irio_setup() {
  irrecv.enableIRIn();
}

//decode_results results;
//The function decode(&results)) is deprecated and may not work as expected! Just use decode() without a parameter and IrReceiver.decodedIRData.<fieldname> .
//関数 decode(&results)) は非推奨であり、期待どおりに動作しない可能性があります。 パラメーターなしで decode() を使用し、 IrReceiver.decodedIRData.<fieldname> を使用するだけです。

void irio_loop() {
  //if(irrecv.decode(&results)){
  if (irrecv.decode()) {//データがあれば
    /*

      SimpleReceiver
      受信したデータが利用可能かどうかを確認し、利用可能な場合はデコードを試みます。
      デコード結果は IrReceiver.decodedIRData 構造にあります。

      例: コマンドは IrReceiver.decodedIRData.command にあります
      アドレスはコマンド内にあります IrReceiver.decodedIRData.address にあります
      および IrReceiver.decodedIRData.decodedRawData 内の最大 32 ビットの生データ
    */
    /*
       \libraries\IRremote\src\IRReceive.cpp.h
       decodedIRData でファイル内を検索して発見

    */
    //rraw = irrecv.decodedIRData.decodedRawData;//読み取った生データ
    radr = irrecv.decodedIRData.address;//?
    rcom = irrecv.decodedIRData.command;//命令部分

    recved(radr, rcom);

    irrecv.resume();//受信復帰
  }

}


void recved(int a, int c) {
  pntcmd(a, c);

  if(c == 71) convIRrecv();
  sAddress = 0xdf;
  sCommand = c;
  irio_send();
}

void irio_send() {
  //グローバル変数を利用　特に意味はない

  setIsIRSending(true);
  // Results for the first loop to: Protocol=NEC Address=0x102 Command=0x34 Raw-Data=0xCB340102 (32 bits)
  irsend.sendNEC(sAddress, sCommand, sRepeats);
  delay(6);
  setIsIRSending(false);//受信復帰

  /*
     If you cannot avoid to send a raw value directly like e.g. 0xCB340102 you must use sendNECRaw()
  */
  //    Serial.println(F("Send NECRaw 0xCB340102"));
  //    IrSender.sendNECRaw(0xCB340102, sRepeats);
}

void pntcmd(int a, int c) {
  Serial.print("ADR:");
  Serial.print(a);
  Serial.print(" , 0x");
  Serial.println(a, HEX);
  Serial.print("COM:");
  Serial.print(c);
  Serial.print(" , 0x");
  Serial.println(c, HEX);
}

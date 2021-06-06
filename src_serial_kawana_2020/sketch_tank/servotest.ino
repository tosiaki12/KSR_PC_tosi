
const int SER = 12;

unsigned long oldtime = 0;
unsigned long ntime = 40;
int nd = 0;//現在の角度 d1°=10(10.555)
bool isreverse = false;

int getnd(){
  return nd;
}

void setup_sert() {
  pinMode(SER, OUTPUT);
}

void loop_sert() {

  oldtime = ntime;
  ntime = millis();
  
  if(ntime - oldtime >= 30){
    if(nd >= 260) isreverse = true;
    if(nd <= 30)  isreverse = false;
    if(isreverse)    nd = nd - 3;
    if(!(isreverse)) nd = nd + 3;
    analogWriteTest(nd*10);
  }
}

void com_sert(char pal) {
  
}


void analogWriteTest(int tm) { //0.5ms~2.4ms:500~2400
  int imm = 20000 - tm;

  for (int i = 0 ; i < 20 ; i++) {
    digitalWrite(SER, HIGH);
    delayMicroseconds(tm);
    digitalWrite(SER, LOW);
    delayMicroseconds(imm);
  }

}

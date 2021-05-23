using System;
using System.Linq;
namespace Serial_kawana_2020
{
    public partial class serial
    {
        readonly string[] coms = { "run f]\r\n", "run u]\r\n", "run h]\r\n", "run m]\r\n", "run s]\r\n" };
        readonly char[] cps = { '前', '後', '左', '右', '停' };//enumを使用?






        void 送信時処理(string sendedText)//送信後に動作
        {
            Console.WriteLine(sendedText);
            if (擬送信チェックボックス.Checked) tryRecData(true, sendedText);
        }

        void 受信時処理(string receivedText)//受信したとき動作
        {

            Console.WriteLine("recieved:"+ receivedText);

            //分解---------------------------------------------------------------------------------------

            /*
             * 小文字アルファベット一文字で内容を判別
             * e : エコー
             * "e102,32" "e0,4"
             *  "102,32"  "0,4"
             * 
             * 
             * 
             */

            switch (receivedText.ElementAt(0))
            {
                default:
                    break;
                case 'e':
                    this.getcoord(receivedText);
                    break;
            }

            //---------------------------------------------------------------------------------------


        }

        void getcoord(String d)
        {
            string rc = d.Substring(1);//'e'を削除
            int sp = rc.IndexOf(',');
            int a = 0;
            Int32.TryParse(rc.Substring(0,  sp), out a);
            int b = 0;
            Int32.TryParse(rc.Substring(sp + 1), out b);
            setCoord(true, a, b);
            prot();
        }

        string[] 分解(string sa)
        {

            string[] cd = { "", "" };
            foreach (char a in sa)
            {
                switch (a)
                {
                    default:
                        break;
                    case ' ':
                        break;
                }
                if (a != ' ')
                {
                    cd[0] += a;
                }
                else if (a == ' ')
                {
                    continue;
                }
            }
            return cd;
        }

        void 命令文送信()
        {

        }

        private void 操作ボタンs_Click(object sender, EventArgs e)
        {

            //通信ログボックス.AppendText(m.ToString());
            string s = sender.ToString();
            char m = s.ElementAt(35);
            switch (m)
            {
                case '前':
                    送信テキストボックス.AppendText(coms[0]);
                    操作状態ラベル.Text = cps[0].ToString();
                    break;
                case '後':
                    送信テキストボックス.AppendText(coms[1]);
                    操作状態ラベル.Text = cps[1].ToString();
                    break;
                case '左':
                    送信テキストボックス.AppendText(coms[2]);
                    操作状態ラベル.Text = cps[2].ToString();
                    break;
                case '右':
                    送信テキストボックス.AppendText(coms[3]);
                    操作状態ラベル.Text = cps[3].ToString();
                    break;
                case '停':
                    送信テキストボックス.AppendText(coms[4]);
                    操作状態ラベル.Text = cps[4].ToString();
                    break;
                default:
                    break;
            }


        }

        private void 試験送信ボタン_Click(object sender, EventArgs e)
        {
            送信テキストボックス.AppendText("test " + commonVir);
            送信ボタン_Click(null, null);
        }








        //---------------------イルミネーション制御

        private void button1_Click(object sender, EventArgs e)
        {
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText("run s;\r\nrun m]\r\n");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string c = "LEDa " + textBox1.Text;
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string c = "LEDb " + textBox2.Text;
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c = "LEDc " + textBox3.Text;
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string c = "LEDd " + textBox4.Text;
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string c = "onLED 0";
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string c = "ofLED 0";
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string c = "poff 0";
            送信テキストボックス.Clear();
            送信テキストボックス.AppendText(c);
            送信ボタン_Click(null, null);
        }





    }
}


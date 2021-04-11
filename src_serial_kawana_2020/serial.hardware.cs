using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Serial_kawana_2020
{
    public partial class serial
    {
        readonly string[] coms = { "run f]\r\n", "run u]\r\n", "run h]\r\n", "run m]\r\n", "run s]\r\n" };
        readonly char[] cps = { '前', '後', '左', '右', '停' };//enumを使用?




        

        void 送信時処理(string sendedText)//受信したときに動作
        {

        }

        void 受信時処理(string receivedText)//送信したとき動作
        {



            //分解---------------------------------------------------------------------------------------




            //---------------------------------------------------------------------------------------


        }

        string[] 分解(string sa)
        {

            string[] cd = { "" , "" };
            foreach ( char a in sa)
            {
                switch (a)
                {
                    default:
                        break;
                    case ' ':
                        break;
                }
                if(a != ' ')
                {
                    cd[0] += a;
                } else if(a == ' ')
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
            送信テキストボックス.AppendText("test "+ commonVir);
            送信ボタン_Click(null, null);
        }
    }
}


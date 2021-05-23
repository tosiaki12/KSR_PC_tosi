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


    public partial class serial : Form
    {
        public static readonly byte commonVir = 1;//arduino側と共通でなければ実行しない


        private String 送信テキスト;//送信時更新
        private String 受信テキスト;

        private String[] 送信データ = { "test", "0" };//四文字程度、一文字
        private String[] 受信データ = { "test", "0" };

        private delegate void delegate_受信データ表示(String text);



        public serial()
        {
            InitializeComponent();
        }

        //開始処理---------------------------------------------------------------------------------------

        private void serial_Load(object sender, EventArgs e)
        {
            //初期化
            状態グリッド初期化();
            通信ログボックス.Clear();
            送信テキストボックス.Clear();
            ポートコンボボックス.Items.Clear();
            //--

            通信ログボックス.AppendText("//開始" + "\r\n");
            String[] ポートリスト = SerialPort.GetPortNames();
            foreach (string p in ポートリスト)
            {
                ポートコンボボックス.Items.Add(p);
            }
        }




        private void 接続ボタン_Click(object sender, EventArgs e)
        {
            if (シリアルポート.IsOpen)
            {
                シリアルポート.Close();
                通信ログボックス.AppendText("//切断" + "\r\n");
                接続ボタン.Text = "接続";
                送信ボタン.BackColor = Color.DarkRed;
                return;
            }

            try
            {
                ポートコンボボックス.SelectedItem.ToString();
            }
            catch (/*NullReference*/Exception ex)
            {
                通信ログボックス.AppendText(ex.ToString() + "\r\n");
                MessageBox.Show("ポートを選択してください", "ポートが不正です");
                return;
            }
            シリアルポート.PortName = ポートコンボボックス.SelectedItem.ToString();
            シリアルポート.BaudRate = 9600;
            シリアルポート.DataBits = 8;//! データビットをセット. (8ビット)
            シリアルポート.Parity = Parity.None;//! パリティビットをセット. (なし)
            シリアルポート.StopBits = StopBits.One; //! ストップビットをセット. (1ビット)
            シリアルポート.Handshake = Handshake.None; //! フロー制御をセット.制御プロトコルなし
            シリアルポート.Encoding = Encoding.ASCII;//! 文字コードをセットする.

            try
            {
                シリアルポート.Open();
            }
            catch (Exception ex)
            {
                通信ログボックス.AppendText(ex.ToString() + "\r\n");
            }
            通信ログボックス.AppendText("//接続" + "\r\n");
            接続ボタン.Text = "切断";
            送信ボタン.BackColor = Color.DarkGreen;


        }

        //---------------------------------------------------------------------------------------




        //繰り返し処理---------------------------------------------------------------------------------------

        private void 状態グリッド初期化()
        {

            状態グリッド.Rows.Add("接続           ", "---", true);
            状態グリッド.Rows.Add("ボーレート     ", "---", 9600);
            状態グリッド.Rows.Add("ポート         ", "---", "COM*");
            状態グリッド.Rows.Add("データビット   ", "---", 8);
            状態グリッド.Rows.Add("パリティビット ", "---", "None");
            状態グリッド.Rows.Add("ストップビット ", "---", "One");
            状態グリッド.Rows.Add("フロー制御     ", "---", "None");
            状態グリッド.Rows.Add("文字コード     ", "---", "ASCII");
            状態グリッド.Rows.Add("---            ", "---", "---");
        }

        private void 確認タイマー_Tick(object sender, EventArgs e)//五秒おきに確認
        {
            String[] ポートリスト = SerialPort.GetPortNames();
            ポートコンボボックス.Items.Clear();
            foreach (string p in ポートリスト)
            {
                ポートコンボボックス.Items.Add(p);
            }

            //状態グリッド.Rows.Add("ポート", シリアルポート.PortName);

            foreach (DataGridViewRow row in 状態グリッド.Rows)
            {
                if ("接続           ".Equals((string)row.Cells[0].Value) &&
                      !(シリアルポート.IsOpen.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.IsOpen.ToString();


                if ("ボーレート     ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.BaudRate.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.BaudRate.ToString();


                if ("ポート         ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.PortName.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.PortName.ToString();


                if ("データビット   ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.DataBits.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.DataBits.ToString();


                if ("パリティビット ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.Parity.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.Parity.ToString();


                if ("ストップビット ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.StopBits.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.StopBits.ToString();

                if ("フロー制御     ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.Handshake.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.Handshake.ToString();

                if ("文字コード     ".Equals((string)row.Cells[0].Value) &&
                    !(シリアルポート.Encoding.ToString().Equals(row.Cells[1].Value.ToString())))
                    row.Cells[1].Value = シリアルポート.Encoding.ToString();




                //row.Cells[1].Value = "12";https://docs.microsoft.com/ja-jp/dotnet/api/system.windows.forms.datagridviewrow.cells?view=netframework-4.8#System_Windows_Forms_DataGridViewRow_Cells
            }

        }

        //---------------------------------------------------------------------------------------




        //送信処理---------------------------------------------------------------------------------------





        private void 送信ボタン_Click(object sender, EventArgs e)
        {
            String 送信テキストk = 送信テキストボックス.Text;
            if (String.IsNullOrWhiteSpace(送信テキストk)) return;
            if (命令化チェックボックス.Checked == true) 送信テキストk = '<' + 送信テキストk + '>';
            if (送信ボタン.BackColor == Color.DarkRed)
            {
                通信ログボックス.AppendText(送信テキストk + "\r\n");
                送信時処理(送信テキストk);
                送信テキストボックス.Clear();
                return;
            }
            try
            {
                シリアルポート.Write(送信テキストk);
            }
            catch (Exception ex)
            {
                通信ログボックス.AppendText(ex.ToString() + "\r\n");
                return;
            }
            通信ログボックス.AppendText("送信-> " + 送信テキストk + "\r\n");
            this.送信テキスト = 送信テキストk;
            送信時処理(this.送信テキスト);
            送信テキストボックス.Clear();
        }







        private void 送信テキストボックス_TextChanged(object sender, EventArgs e)
        {
            /*
             * ';'は命令の改行
             * ']'は命令の送信（最終行）
             * 
             * 送信ボタンを押さなくても送信文字があれば送信
             * 
             */
            string text = 送信テキストボックス.Text;

            if (text.EndsWith("]\r\n"))
            {
                text = text.Remove(text.Length - 3);//]\r\nを削除
                if (text.EndsWith(";\r\n")) text = text.Remove(text.Length - 3);
                string[] r = { ";\r\n" };
                string[] coms = text.Split(r, StringSplitOptions.RemoveEmptyEntries);

                foreach (string c in coms)
                {
                    送信テキストボックス.Clear();
                    送信テキストボックス.AppendText(c);
                    送信ボタン_Click(null, null);
                    //送信ごとに間隔を空けられるようにする（数十ミリ秒くらい）
                }
            }

        }
        //---------------------------------------------------------------------------------------

        //受信処理---------------------------------------------------------------------------------------




        private void シリアルポート_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            tryRecData(false, "ddd");
        }

        private void tryRecData(bool isuseD, string dData)
        {
            //https://www.atmarkit.co.jp/ait/articles/0506/17/news111.html
            //Windowsフォームで別スレッドからコントロールを操作するには？
            //if (!(シリアルポート.IsOpen)) return;
            try
            {
                string data = "nowrite";
                if (!(isuseD)) data = シリアルポート.ReadTo("\r\n");//改行まで読む

                if (isuseD) data = dData;//擬受信用

                delegate_受信データ表示 d = new delegate_受信データ表示(受信データ表示);
                Invoke(d, data);//安全にdを呼び出す
                //Invoke(new delegate_受信データ表示(受信データ表示), new Object[] { data });
            }
            catch (Exception ex)
            {
                通信ログボックス.AppendText(ex.ToString() + "\r\n");
            }



        }

        private void 受信データ表示(string text)
        {
            通信ログボックス.AppendText("受信-> " + text + "\r\n");
            this.受信テキスト = text;
            受信時処理(this.受信テキスト);
        }




        //---------------------------------------------------------------------------------------






        //停止処理---------------------------------------------------------------------------------------
        private void 出力切断ボタン_Click(object sender, EventArgs e)//実装中
        {
            if (出力切断ボタン.BackColor == Color.Firebrick)
            {
                送信テキストボックス.AppendText("poff]\r\n");
                出力切断ボタン.BackColor = Color.Green;
                出力切断ボタン.Text = "復\r\n帰";
            }
            else if (出力切断ボタン.BackColor == Color.Green)
            {
                送信テキストボックス.AppendText("res]\r\n");//未実装
                出力切断ボタン.BackColor = Color.Firebrick;
                出力切断ボタン.Text = "切\r\n断";
            }

        }
        //---------------------------------------------------------------------------------------



        //終了処理---------------------------------------------------------------------------------------

        private void serial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (シリアルポート.IsOpen) シリアルポート.Close();
        }





        //---------------------------------------------------------------------------------------

        private void 擬送信チェックボックス_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 座標擬送信ボタン_Click(object sender, EventArgs e)
        {
            int t = (int)cdnA.Value;
            int y = (int)cdnB.Value;
            string a = "e" + t.ToString();
            string b = y.ToString();
            送信テキストボックス.AppendText(a + "," + b + "]\r\n");
        }
    }
}

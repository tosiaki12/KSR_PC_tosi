using System;
using System.Drawing;
using System.Windows.Forms;
namespace Serial_kawana_2020
{



    /*
     * 
     * ソナー画面の描画
     * 
     * （探知開始ボタンを押されたら初期化、開始命令を送信）
     * 
     * 受け取った仮想的な座標（中心下あたりを原点とする）を
     * 実際の座標（原点（180,300））に変換して表示
     * 
     * 消去ボタンを押されたら画面をクリア
     * ？（ブリップを記録し一定数超えたら削除）
     * ？（探査している角度の直線）
     */


    public partial class serial
    {
        int x仮 = 0;//直交座標　描画ではこれを使用
        int y仮 = 0;
        int x仮極 = 0;
        int y仮極 = 0;
        int x実 = 0;
        int y実 = 0;
        Graphics echoPGrh;
        SolidBrush mkB = new SolidBrush(Color.Green);
        SolidBrush erB = new SolidBrush(Color.DimGray);

        bool isstart = false;//探知開始ボタンが押されているか　いなければプロットしない


        void setCoord(bool ispole, int a, int b)
        {
            Console.WriteLine("coord " + ispole.ToString() + " " + a.ToString() + " " + b.ToString());
            if (!(ispole))//直交座標の時
            {
                x仮 = a;
                y仮 = b;
                x仮極 = (int)Math.Sqrt(a ^ 2 + b ^ 2);
                if (a == 0) a = a + 1;
                    y仮極 = (int)Math.Atan(b / a);

                /*
                try
                {
                    y仮極 = (int)Math.Atan(b / a);
                }
                catch (System.DivideByZeroException)
                {
                    y仮極 = 0;
                }
                */

            }
            else//極座標の時
            {
                x仮極 = a;
                x仮極 = b;
                x仮 = (int)(a * Math.Cos(b * (Math.PI / 180)));
                y仮 = (int)(a * Math.Sin(b * (Math.PI / 180)));
            }

            x実 = cvx(x仮);
            y実 = cvy(y仮);
        }

        void prot()
        {
            //x仮,y仮　のデータをグラフに表示
            Console.WriteLine("prot atmpt " + x仮.ToString() + " " + y仮.ToString());
            echoPGrh = splitContainer2.Panel1.CreateGraphics();
            if (isstart) echoPGrh.FillEllipse(mkB, x実, y実, 8, 8);
            echoPGrh.Dispose();
        }
        void remove()
        {
            //x仮,y仮　のデータをグラフから削除
            echoPGrh = splitContainer2.Panel1.CreateGraphics();
            if (isstart) echoPGrh.FillEllipse(erB, x実, y実, 8, 8);
            echoPGrh.Dispose();
        }
        
        private int cvx(int x)
        {
            //仮想座標を実際の座標に変換
            x = 180 + x;
            return x;
        }
        private int cvy(int y)
        {
            y = 300 - y;
            return y;
        }
        

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            echoPGrh = e.Graphics;
            initDraw();
            echoPGrh.Dispose();
        }

        private void 探知開始ボタン_Click(object sender, EventArgs e)
        {
            if (!(isstart))
            {
                isstart = true;
                探知開始ボタン.Text = "探知停止";
                //echoPGrh = splitContainer2.Panel1.CreateGraphics();
                initDraw();
                送信テキストボックス.AppendText( "echo b]\r\n");
            } else
            {
                isstart = false;
                探知開始ボタン.Text = "探知開始";
                //echoPGrh.Dispose();
                送信テキストボックス.AppendText("echo e]\r\n");
            }
        }

        private void initDraw()
        {
            echoPGrh = splitContainer2.Panel1.CreateGraphics();
            Pen gline = new Pen(Color.Green, 2);
            SolidBrush baseB = new SolidBrush(Color.Green);
            echoPGrh.FillRectangle(baseB, cvx(-15), cvy(20), 30, 40);
            echoPGrh.DrawLine(gline, cvx(-150), cvy(0), cvx(150), cvy(0));
            echoPGrh.DrawLine(gline, cvx(0), cvy(-180), cvx(0), cvy(180));
            echoPGrh.Dispose();
        }

        private void readNumBox()
        {
            if (checkBox1.Checked)
            {
                setCoord(true, (int)cdnA.Value, (int)cdnB.Value);
            }
            else
            {
                setCoord(false, (int)cdnA.Value, (int)cdnB.Value);
            }
        }


        private void 表示テスト_Click(object sender, EventArgs e)
        {
            readNumBox();
            prot();
        }


        private void 消去テスト_Click(object sender, EventArgs e)
        {
            readNumBox();
            remove();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            echoPGrh = splitContainer2.Panel1.CreateGraphics();
            echoPGrh.Clear(Color.DimGray);
            echoPGrh.Dispose();
            initDraw();
        }


        private void 座標擬送信ボタン_Click(object sender, EventArgs e)
        {
            int t = (int)cdnA.Value;
            int y = (int)cdnB.Value;
            string a = "d" + t.ToString();
            string b = y.ToString();
            送信テキストボックス.AppendText(a + "," + b + "]\r\n");
        }


    }

}


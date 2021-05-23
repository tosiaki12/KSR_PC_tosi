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
     * （消去ボタンを押されたら画面をクリア）
     * ？（ブリップを記録し一定数超えたら削除）
     * 
     */


    public partial class serial
    {
        int x仮 = 0;//直交座標　描画ではこれを使用
        int y仮 = 0;
        int x仮極 = 0;
        int y仮極 = 0;
        Graphics echoPGrh;
        SolidBrush mkB = new SolidBrush(Color.Green);
        SolidBrush erB = new SolidBrush(Color.DimGray);

        bool isstart = false;//探知開始ボタンが押されているか　いなければプロットしない


        void setCoord(bool ispole, int a, int b)
        {
            if (!(ispole))//直交座標の時
            {
                x仮 = a;
                y仮 = b;
                x仮極 = (int)Math.Sqrt(a ^ 2 + b ^ 2);

                try
                {
                    y仮極 = (int)Math.Atan(b / a);
                }
                catch (System.DivideByZeroException)
                {
                    y仮極 = 0;
                }

            }
            else//極座標の時
            {
                x仮極 = a;
                x仮極 = b;
                x仮 = (int)(a * Math.Cos(b * (Math.PI / 180)));
                y仮 = (int)(a * Math.Sin(b * (Math.PI / 180)));
            }
        }

        void prot()
        {
            //x仮,y仮　のデータをグラフに表示
            if (isstart) echoPGrh.FillEllipse(mkB, cvx(x仮), cvy(y仮), 8, 8);
        }
        void remove()
        {
            //x仮,y仮　のデータをグラフから削除
            if (isstart) echoPGrh.FillEllipse(erB, cvx(x仮), cvy(y仮), 8, 8);
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
                echoPGrh = splitContainer2.Panel1.CreateGraphics();
                initDraw();
            } else
            {
                isstart = false;
                探知開始ボタン.Text = "探知開始";
                echoPGrh.Dispose();
            }
        }

        private void initDraw()
        {
            Pen gline = new Pen(Color.Green, 2);
            SolidBrush baseB = new SolidBrush(Color.Green);
            echoPGrh.FillRectangle(baseB, cvx(-15), cvy(20), 30, 40);
            echoPGrh.DrawLine(gline, cvx(-150), cvy(0), cvx(150), cvy(0));
            echoPGrh.DrawLine(gline, cvx(0), cvy(-180), cvx(0), cvy(180));
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
            echoPGrh.Clear(Color.DimGray);
            initDraw();
        }

    }

}


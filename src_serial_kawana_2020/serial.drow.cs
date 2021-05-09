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
        int 仮x = 0;
        int 仮y = 0;


        private int cvx(int x)
        {
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
            Graphics g = e.Graphics;
            Pen gline = new Pen(Color.Green, 2);
            g.DrawRectangle(gline, cvx(-15), cvy(20), 30, 40);
            g.DrawLine(gline, cvx(-150), cvy(0), cvx(150), cvy(0));
            g.DrawLine(gline, cvx(0), cvy(-180), cvx(0), cvy(180));

            gg = splitContainer2.Panel1.CreateGraphics();
        }
        Graphics gg;




        private void initDraw()
        {
            Pen gline = new Pen(Color.Green, 2);
            SolidBrush baseB = new SolidBrush(Color.Green);
            gg.FillRectangle(baseB, cvx(-15), cvy(20), 30, 40);
            gg.DrawLine(gline, cvx(-150), cvy(0), cvx(150), cvy(0));
            gg.DrawLine(gline, cvx(0), cvy(-180), cvx(0), cvy(180));
        }



        SolidBrush mkB = new SolidBrush(Color.Green);
        SolidBrush erB = new SolidBrush(Color.DimGray);

        private void button8_Click(object sender, EventArgs e)
        {

            仮x = (int)numericUpDown1.Value;
            仮y = (int)numericUpDown2.Value;

            if (checkBox1.Checked)
            {
                int kx = 仮x;
                int ky = 仮y;
                仮x = (int)(kx * Math.Cos(ky * (Math.PI / 180)));
                仮y = (int)(kx * Math.Sin(ky * (Math.PI / 180)));
            }
            

            gg.FillEllipse(mkB, cvx(仮x), cvy(仮y), 8, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            仮x = (int)numericUpDown1.Value;
            仮y = (int)numericUpDown2.Value;
            gg.FillEllipse(erB, cvx(仮x), cvy(仮y), 10, 10);
        }



        private void button10_Click(object sender, EventArgs e)
        {
            gg.Clear(Color.DimGray);
            initDraw();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }

}


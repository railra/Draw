using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        int Heightt = 700;
        int Widthh = 700;
        int Square = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1f);

            Point[] points = new Point[1000];

            for (int i = 0; i < points.Length; i++)
            {

                //points[i] = new Point(i, (int)(Math.Sin((double)i/50) * 100 + 200));

                points[i] = new Point(i + (Heightt / 2), ((((int)(2.5f * (i))) * -1) + Heightt) - (Square * 3) - (Heightt / 2));

            }
            graphics.DrawLines(pen, points);
            for (int i = Heightt / Square; i >= 0; i--)
            {
                if (i == (Heightt / Square) / 2)
                {
                    pen.Color = Color.Red;
                }
                else
                {
                    pen.Color = Color.Black;
                }
                graphics.DrawLine(pen, 0, i * Square, Widthh, i * Square);
            }
            for (int i = Widthh / Square; i >= 0; i--)
            {
                if (i == (Heightt / Square) / 2)
                {
                    pen.Color = Color.Red;
                }
                else
                {
                    pen.Color = Color.Black;
                }
                graphics.DrawLine(pen, i * Square, 0, i * Square, Heightt);
            }
        }
    }
}

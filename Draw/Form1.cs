using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        int Heightt = 700;
        int Widthh = 700;
        int Square = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1f);

            Point[] points = new Point[1000];
            Point[] points2 = new Point[1000];
            Point[] points3 = new Point[1000];
            Point[] points4 = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                double y;
                points[i] = new Point((i) + (Widthh / 2), (int)((((2.5f * (i))) * -1)) - (Square * 3) + (Heightt / 2));
                points2[i] = new Point((i - 999) + (Widthh / 2), (int)((((2.5f * (i - 999))) * -1)) - (Square * 3) + (Heightt / 2));
            }
            double g = 0.0;
            for (int i = 0; i < points.Length; i++)
            {

                points3[i] = new Point((i) + (Widthh / 2), (int)(((((g * g) - 3 * g) * -1) - 9) * Square + (Heightt / 2)));
                points4[i] = new Point((i - 999) + (Widthh / 2), (int)((((((g - 99.9) * (g - 99.9)) - 3 * (g - 99.9)) * -1) - 9) * Square + (Heightt / 2)));
                if (i == 2)
                {
                    button1.Text = ((((i * i) - 3 * i) * -1) - (9 * Square) + (Heightt / 2)).ToString();
                }
                g += 0.1;

            }
            graphics.DrawLines(pen, points);
            graphics.DrawLines(pen, points2);
            graphics.DrawLines(pen, points3);
            graphics.DrawLines(pen, points4);
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
                if (i == (Widthh / Square) / 2)
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

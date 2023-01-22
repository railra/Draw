using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        int heightField = 800;
        int widthField = 800;
        int square = 20;
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int middleOfFieldInHeight = heightField / 2;
            int middleOfFieldInWidth = widthField / 2;
            float neg = 999/square;
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1f);

            Point[] points = new Point[1000];
            Point[] points2 = new Point[1000];
            Point[] points3 = new Point[1000];
            Point[] points4 = new Point[1000];
            double l = 0f / square;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point((i) + middleOfFieldInWidth, (int)((((((2.5f * (l))) * -1)) - 3) * square + middleOfFieldInHeight));
                points2[i] = new Point((i - (1000-square)) + middleOfFieldInWidth, (int)((((((2.5f * (l - neg))) * -1)) - 3) * (square) + middleOfFieldInHeight));
                l += (1f / square);
            }
            double g = 0f / square;
            for (int i = 0; i < points.Length; i++)
            {
                points3[i] = new Point((i) + middleOfFieldInWidth, (int)(((((g * g) - 3 * g) * -1) - 9) * square + middleOfFieldInHeight));
                points4[i] = new Point((i - (1000-square)) + middleOfFieldInWidth, (int)((((((g - neg) * (g - neg)) - 3 * (g - neg)) * -1) - 9) * square + middleOfFieldInHeight));
                g += (1f / square);

            }
            graphics.DrawLines(pen, points);
            graphics.DrawLines(pen, points2);
            graphics.DrawLines(pen, points3);
            graphics.DrawLines(pen, points4);

            for (int i = heightField / square; i >= 0; i--)
            {
                if (i == (heightField / square) / 2)
                {
                    pen.Color = Color.Red;
                    pen.Width = 2f;
                }
                else
                {
                    pen.Color = Color.Black;
                    pen.Width = 1f;
                }
                graphics.DrawLine(pen, 0, i * square, widthField, i * square);
            }
            for (int i = widthField / square; i >= 0; i--)
            {
                if (i == (widthField / square) / 2)
                {
                    pen.Color = Color.Red;
                    pen.Width = 2f;
                }
                else
                {
                    pen.Color = Color.Black;
                    pen.Width = 1f;
                }
                graphics.DrawLine(pen, i * square, 0, i * square, heightField);
            }
        }
    }
}

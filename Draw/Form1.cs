using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        int heightField = 800;
        int widthField = 800;
        int cellSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int middleOfFieldInHeight = heightField / 2;
            int middleOfFieldInWidth = widthField / 2;
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            int interval;
            if (radioButton1.Checked == true)
            {
                cellSize = Int32.Parse(radioButton1.Text);
                interval = 10;
            }
            else if (radioButton2.Checked == true)
            {
                cellSize = Int32.Parse(radioButton2.Text);
                interval = 5;
            }
            else if (radioButton3.Checked == true)
            {
                cellSize = Int32.Parse(radioButton3.Text);
                interval = 4;
            }
            else if (radioButton4.Checked == true)
            {
                cellSize = Int32.Parse(radioButton4.Text);
                interval = 2;
            }
            else if (radioButton5.Checked == true)
            {
                cellSize = Int32.Parse(radioButton5.Text);
                interval = 2;
            }
            else
            {
                cellSize = Int32.Parse(radioButton6.Text);
                interval = 1;
            }
            using (Font myFont = new Font("Arial", 12, FontStyle.Bold))
            {
                int sizeOfInteval;
                graphics.DrawString("O", myFont, Brushes.Red, new Point(middleOfFieldInWidth, middleOfFieldInHeight));
                for (int i = 1; i <= 10; i++)
                {
                    sizeOfInteval = cellSize * (interval * i);
                    graphics.DrawString((interval * i).ToString(), myFont, Brushes.Blue, new Point(middleOfFieldInWidth + sizeOfInteval, middleOfFieldInHeight));
                    graphics.DrawString((interval * -i).ToString(), myFont, Brushes.Blue, new Point(middleOfFieldInWidth, middleOfFieldInHeight + sizeOfInteval));
                    graphics.DrawString((interval * -i).ToString(), myFont, Brushes.Blue, new Point(middleOfFieldInWidth - sizeOfInteval, middleOfFieldInHeight));
                    graphics.DrawString((interval * i).ToString(), myFont, Brushes.Blue, new Point(middleOfFieldInWidth, middleOfFieldInHeight - sizeOfInteval));
                }
            }

            Pen pen = new Pen(Color.Black, 1f);

            for (int i = heightField / cellSize; i >= 0; i--)
            {
                if (i == (heightField / cellSize) / 2)
                {
                    pen.Color = Color.Red;
                    pen.Width = 2f;
                }
                else
                {
                    pen.Color = Color.Black;
                    pen.Width = 1f;
                }
                graphics.DrawLine(pen, 0, i * cellSize, widthField, i * cellSize);
            }
            for (int i = widthField / cellSize; i >= 0; i--)
            {
                if (i == (widthField / cellSize) / 2)
                {
                    pen.Color = Color.Red;
                    pen.Width = 2f;
                }
                else
                {
                    pen.Color = Color.Black;
                    pen.Width = 1f;
                }
                graphics.DrawLine(pen, i * cellSize, 0, i * cellSize, heightField);
            }

            Point[] points = new Point[1000];
            Point[] points2 = new Point[1000];
            Point[] points3 = new Point[1000];
            Point[] points4 = new Point[1000];
            double l = 0;
            float neg = 999 / cellSize;
            double function1Right;
            double function1Left;
            double function2Right;
            double function2Left;
            for (int i = 0; i < points.Length; i++)
            {
                function1Right = ((2.5f * l)) * -1 - 3;
                function1Left = (2.5f * (l - neg)) * -1 - 3;
                points[i] = new Point((i) + middleOfFieldInWidth, (int)(function1Right * cellSize + middleOfFieldInHeight));
                points2[i] = new Point((i - (1000 - cellSize)) + middleOfFieldInWidth, (int)(function1Left * (cellSize) + middleOfFieldInHeight));
                l += (1f / cellSize);
            }

            double g = 0;
            for (int i = 0; i < points.Length; i++)
            {
                function2Right = ((g * g - 3 * g) * -1 - 9);
                function2Left = ((g - neg) * (g - neg) - 3 * (g - neg)) * -1 - 9;
                points3[i] = new Point((i) + middleOfFieldInWidth, (int)(function2Right * cellSize + middleOfFieldInHeight));
                points4[i] = new Point((i - (1000 - cellSize)) + middleOfFieldInWidth, (int)(function2Left * cellSize + middleOfFieldInHeight));
                g += (1f / cellSize);
            }

            pen.Color = Color.Green;
            pen.Width = 3f;
            graphics.DrawLines(pen, points);
            graphics.DrawLines(pen, points2);
            pen.Color = Color.Purple;
            graphics.DrawLines(pen, points3);
            graphics.DrawLines(pen, points4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        Field field = new Field();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int middleOfFieldInHeight = field.heightField / 2;
            int middleOfFieldInWidth = field.widthField / 2;
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            int interval;
            if (radioButton1.Checked == true)
            {
                field.cellSize = Int32.Parse(radioButton1.Text);
                interval = 10;
            }
            else if (radioButton2.Checked == true)
            {
                field.cellSize = Int32.Parse(radioButton2.Text);
                interval = 5;
            }
            else if (radioButton3.Checked == true)
            {
                field.cellSize = Int32.Parse(radioButton3.Text);
                interval = 4;
            }
            else if (radioButton4.Checked == true)
            {
                field.cellSize = Int32.Parse(radioButton4.Text);
                interval = 2;
            }
            else if (radioButton5.Checked == true)
            {
                field.cellSize = Int32.Parse(radioButton5.Text);
                interval = 2;
            }
            else
            {
                field.cellSize = Int32.Parse(radioButton6.Text);
                interval = 1;
            }
            

            

            field.Grid(graphics, pen, interval);

            Point[] points = new Point[1000];
            Point[] points2 = new Point[1000];
            Point[] points3 = new Point[1000];
            Point[] points4 = new Point[1000];
            double l = 0;
            float neg = 999 / field.cellSize;
            double function1Right;
            double function1Left;
            double function2Right;
            double function2Left;
            for (int i = 0; i < points.Length; i++)
            {
                function1Right = ((2.5f * l)) * -1 - 3;
                function1Left = (2.5f * (l - neg)) * -1 - 3;
                points[i] = new Point((i) + middleOfFieldInWidth, (int)(function1Right * field.cellSize + middleOfFieldInHeight));
                points2[i] = new Point((i - (1000 - field.cellSize)) + middleOfFieldInWidth, (int)(function1Left * (field.cellSize) + middleOfFieldInHeight));
                l += (1f / field.cellSize);
            }

            double g = 0;
            for (int i = 0; i < points.Length; i++)
            {
                function2Right = ((g * g - 3 * g) * -1 - 9);
                function2Left = ((g - neg) * (g - neg) - 3 * (g - neg)) * -1 - 9;
                points3[i] = new Point((i) + middleOfFieldInWidth, (int)(function2Right * field.cellSize + middleOfFieldInHeight));
                points4[i] = new Point((i - (1000 - field.cellSize)) + middleOfFieldInWidth, (int)(function2Left * field.cellSize + middleOfFieldInHeight));
                g += (1f / field.cellSize);
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

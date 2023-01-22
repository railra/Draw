using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        Field field = new Field();
        Functions functions= new Functions();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
            functions.DrawFunction1(field, graphics, pen);
            functions.DrawFunction2(field, graphics, pen);
        }
    }
}

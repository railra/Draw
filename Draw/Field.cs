using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    internal class Field
    {
        public int cellSize;
        public int heightField = 800;
        public int widthField = 800;
        public void Grid(Graphics graphics, Pen pen, int interval)
        {
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
            using (Font myFont = new Font("Arial", 12, FontStyle.Bold))
            {
                int sizeOfInteval;
                graphics.DrawString("O", myFont, Brushes.Red, new Point(widthField / 2, heightField / 2));
                for (int i = 1; i <= 10; i++)
                {
                    sizeOfInteval = cellSize * (interval * i);
                    graphics.DrawString((interval * i).ToString(), myFont, Brushes.Blue, new Point(widthField / 2 + sizeOfInteval, heightField / 2));
                    graphics.DrawString((interval * -i).ToString(), myFont, Brushes.Blue, new Point(widthField / 2, heightField / 2 + sizeOfInteval));
                    graphics.DrawString((interval * -i).ToString(), myFont, Brushes.Blue, new Point(widthField / 2 - sizeOfInteval, heightField / 2));
                    graphics.DrawString((interval * i).ToString(), myFont, Brushes.Blue, new Point(widthField / 2, heightField / 2 - sizeOfInteval));
                }
            }
        }
    }
}

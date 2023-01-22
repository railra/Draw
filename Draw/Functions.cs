using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    internal class Functions
    {

        Point[] points = new Point[1000];
        Point[] points2 = new Point[1000];
        Point[] points3 = new Point[1000];
        Point[] points4 = new Point[1000];
        
        double function1Right;
        double function1Left;
        double function2Right;
        double function2Left;
        public void DrawFunction1(Field field, Graphics graphics ,Pen pen)
        {
            double l = 0;
            pen.Width = 3f;
            float neg = 999 / field.cellSize;
            for (int i = 0; i < points.Length; i++)
            {
                function1Right = ((2.5f * l)) * -1 - 3;
                function1Left = (2.5f * (l - neg)) * -1 - 3;
                points[i] = new Point((i) + field.widthField/2, (int)(function1Right * field.cellSize + field.heightField / 2));
                points2[i] = new Point((i - (1000 - field.cellSize)) + field.widthField / 2, (int)(function1Left * (field.cellSize) + field.heightField / 2));
                l += (1f / field.cellSize);
            }
            pen.Color = Color.Green;
            graphics.DrawLines(pen, points);
            graphics.DrawLines(pen, points2);
        }
        public void DrawFunction2(Field field, Graphics graphics, Pen pen)
        {
            double g = 0;
            pen.Width = 3f;
            float neg = 999 / field.cellSize;
            for (int i = 0; i < points.Length; i++)
            {
                function2Right = ((g * g - 3 * g) * -1 - 9);
                function2Left = ((g - neg) * (g - neg) - 3 * (g - neg)) * -1 - 9;
                points3[i] = new Point((i) + field.widthField / 2, (int)(function2Right * field.cellSize + field.heightField / 2));
                points4[i] = new Point((i - (1000 - field.cellSize)) + field.widthField / 2, (int)(function2Left * field.cellSize + field.heightField / 2));
                g += (1f / field.cellSize);
            }
            pen.Color = Color.Purple;
            graphics.DrawLines(pen, points3);
            graphics.DrawLines(pen, points4);
        }
    }
}

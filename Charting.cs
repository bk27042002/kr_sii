using System;
using System.Drawing;

namespace kr_sii
{
    internal class Charting
    {
        private int x0;
        private int y0;
        private int y1;
        private int knot;
        private string imagePath;

        public Charting(int x0, int y0, int y1, int knot, string imagePath)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.y1 = y1;
            this.knot = knot;
            this.imagePath = imagePath;
        }

        public Bitmap DrawChart(double side, double sideP, double keel, double width, double widthP, double keelWidth, Data data)
        {
            float angle = (float)Сalculations.ConvertToRadian(180 - (float)data.angle);
            Bitmap image = new Bitmap(imagePath);

            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Orange)), 
                    (float)(x0 - side * knot) + 4, y1, (float)(width * knot), y0);

                graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Red)), 
                    (float)(x0 - sideP * knot) + 4, y1, (float)(widthP * knot), y0);

                graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Yellow)), 
                    (float)(x0 - keel * knot) + 4, y1, (float)(keelWidth * knot), y0);

                float x = (float)((data.speedShip * knot) * Math.Cos(angle) + x0);
                float y = (float)(y0-(data.speedShip * knot) * Math.Sin(angle));

                graphics.FillEllipse(new SolidBrush(Color.Blue), x, y, 15, 15);
            }

            return image;
        }
    }
}
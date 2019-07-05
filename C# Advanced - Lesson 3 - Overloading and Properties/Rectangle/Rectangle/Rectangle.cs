using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }

        public int Width
        {
            get
            {
                return X2 - X1;
            }

            set
            {
                X2 = X1 + value;
            }
        }

        public int Height
        {
            get
            {
                return Y2 - Y1;
            }

            set
            {
                Y2 = Y1 + value;
            }
        }

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Rectangle(int width, int height)
        {
            X1 = 0;
            Y1 = 0;
            X2 = width;
            Y2 = height;
        }

        public int Hekef()
        {
            return 2 * (Width + Height);
        }

        public int Shetach()
        {
            return Width * Height;
        }
    }
}

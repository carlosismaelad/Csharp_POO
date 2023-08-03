using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectangleArea
{
    public class Rectangle
    {
        public double Width;
        public double Height;

        public double Area(){
            return Width * Height;
        }

        public double Perimeter(){
            return 2 * (Width + Height);
        }

        public double Diagonal(){
        return Math.Sqrt((Width * Width) + (Height * Height));
        }
    }
}
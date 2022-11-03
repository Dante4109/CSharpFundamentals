using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.DesignPatterns.SOLID
{

    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    class Square : Rectangle
    {
        private int _height;
        private int _width;

        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }

    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineCalculator
{
    internal class Triangle
    {
        public double width { get; set; }
        public double height { get; set; }
        public double area { get; set; }
        public double perimeter { get; set; }

        public Triangle() { }

        public Triangle (double height, double width) {
            area = (height * width) / 2;

            perimeter = height + width + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));
        }
    }
}

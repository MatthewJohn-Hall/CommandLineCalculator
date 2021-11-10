using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineCalculator
{
    internal class Circle
    {
        public double width { get; set; }
        public double height { get; set; }
        public double area { get; set; }
        public double perimeter { get; set; }

        public Circle() { }

        public Circle (double height)
        {
            area = Math.PI * Math.Pow(height, 2);

            perimeter = 2 * height * Math.PI;
        }

    }
}

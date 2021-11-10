using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineCalculator
{
    internal class Square
    {
        public double width { get; set; }
        public double height { get; set; }
        public double area { get; set; }
        public double perimeter { get; set; }

        public Square() { }

        public Square (double height, double width)
        {
            area = (height * width);

            perimeter = (height + width) * 2;
        }

    }
}

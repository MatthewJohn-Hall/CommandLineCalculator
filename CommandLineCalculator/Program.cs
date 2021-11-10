using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input 1. for Square, 2. for triangle, 3. for circle:");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            double h;
            double w;

            switch (choice) {

                case 1:
                    Console.Write("Please input a height:");
                    h = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please input a width:");
                    w = Convert.ToInt32(Console.ReadLine());
                    Square sq = new Square(h, w);
                    Console.Write("The Area of the square is {0} and it's Perimeter is {1}", sq.area, sq.perimeter);
                    break;

                case 2:
                    Console.Write("Please input a height:");
                    h = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please input a width:");
                    w = Convert.ToInt32(Console.ReadLine());
                    Triangle tri = new Triangle(h, w);
                    Console.Write("The Area of the triangle is {0} and it's Perimeter is {1}", tri.area, tri.perimeter);
                    break;

                case 3:
                    Console.Write("Please input a radius:");
                    h = Convert.ToInt32(Console.ReadLine());
                    Circle cir = new Circle(h);
                    Console.Write("The Area of the triangle is {0} and it's Perimeter is {1}", cir.area, cir.perimeter);
                    break;
            }

            Console.ReadLine();



        }
    }
}

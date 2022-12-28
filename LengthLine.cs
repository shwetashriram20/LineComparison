using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LineCmp
{
    public class LengthLine
    {
        public static void calculateLengthLine()
        {
            double Length = 0.0;
            
            Console.WriteLine("Calculating length of two points of x,y Co-ordinates : \n");
            
            Console.WriteLine("Enter x1 y1 x2 y2 value of first point : ");
            
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Length = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine("\nThe length of two points is: " + Length);
        }
    }
}
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
            double Length1 = 0.0;
            double Length2 = 0.0;
            
            
            Console.WriteLine("Enter x1,y1,x2,y2 values of first point : ");
            
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Length1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));


            Console.WriteLine("Enter x1,y1,x2,y2 values of secound point : ");

            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());

            Length2 = Math.Sqrt((Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2)));
            
            Console.WriteLine("length1:: {0}    length2:: {1} ", Length1, Length2);
           
            if (Length1 == Length2)
            {
                Console.WriteLine("Two lines are equal");
            }
            
            else
            {
                Console.WriteLine("two lines are not equal");
            }
        }
    }
}

        
    

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLineComparision
{
    public class GeometryLineProblem
    {
        public static void CompareTwoLineEualareNot()
        {
            //for length 1


            Console.WriteLine("Enter the x-cordinate of point 1 : x1");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 1 : y1");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x-cordinate of point 2 : x2");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 2 : y2");
            int y2 = Convert.ToInt32(Console.ReadLine());


            double length1 = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));

            Console.WriteLine("Distance between two points: " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ") is :" + length1);

            // for length 2 
            Console.WriteLine("Enter the x-cordinate of point 1 : x3");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 1 : y3");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x-cordinate of point 2 : x4");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the y-cordinate of point 1 : y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt(((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3)));

            

            Console.WriteLine("Distance between two points: " + "(" + x3 + "," + y3 + ")" + "(" + x4 + "," + y4 + ") is :" + length2);

            //Compare the length

            if (length1 == length2)
            {
                Console.WriteLine("Both the line are equal");
            }
            else
            {
                Console.WriteLine("Both the line are not equal");

                if (length1 > length2)
                {
                    Console.WriteLine("Length of Line 1 is Greater than Line 2");
                }
                else
                {
                    Console.WriteLine("Length of Line 2 is Greater than Line 1");
                }

            }
        }
    }
}

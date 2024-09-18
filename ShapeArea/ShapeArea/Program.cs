﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you like to find the area of? Please enter r for rectangle or enter t for triangle or enter any other key for circle");
            answer = Console.ReadLine();

            if(answer == "r")
            {
                Console.WriteLine("Please enter the heigh of the rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enre the width of the rectangle.");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "t")
            {
                Console.WriteLine("Please enter the heigh of the rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enre the width of the rectangle.");
                float width = float.Parse(Console.ReadLine());

                result = (float)0.5 * height * width;
            }
            else
            {
                Console.WriteLine("Please enter radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }

    }
}

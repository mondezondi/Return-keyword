﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
            cube(5);
            Console.ReadLine();
        }

         static int cube(int number)
        {
            int result = number * number * number;
            return result;
        }
    }
}

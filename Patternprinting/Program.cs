﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patternprinting
{
    class Program
    {
        static void Main(string[] args)
        {

//1
//2 3
//4 5 6
//7 8 9 10

            int k = 1;
            for (int i = 0; i <= 3; i++)
            {
               
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(k);
                    Console.Write(" ");
                    k++;
                }

                Console.WriteLine(" ");
            }
            Console.ReadKey();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7) 
                {
                    Console.WriteLine("Found seven!");
                    break;
                }

            }

            for (int myValue = 0; myValue < 100; myValue++)
            {
                Console.WriteLine(myValue);
               
            }




            Console.ReadLine();
        }
    }
}

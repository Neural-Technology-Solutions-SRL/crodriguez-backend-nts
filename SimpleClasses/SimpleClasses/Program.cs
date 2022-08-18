using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Newsmobile ";
            myCar.Model = "Dodge Challenger ";
            myCar.Year = 2016;
            myCar.Color = " Black";

            Console.WriteLine("{0}{1}{2}{3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
              
        }   
        
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 1200.0M;

            // Someday I might look up the car
            // online webservice to get more
            // accurate value.
            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }  

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1999)
                carValue = 10500;
            else
                carValue = 3000;

            return carValue;
        }
    }
}
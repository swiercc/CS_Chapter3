using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hourly Rate:");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());

            double weeklyRate = hourlyRate * 40.00;

            if (hourlyRate < 5.65 || hourlyRate > 49.99)
            {
                Console.WriteLine("Hourly Rate:");
                hourlyRate = Convert.ToDouble(Console.ReadLine());


                if (hourlyRate < 5.65 || hourlyRate > 49.99)
                {
                    Console.WriteLine("error");
                }
            }
            
            if (hourlyRate >= 5.65 && hourlyRate <= 49.99)
               
                Console.WriteLine("Hourly Rate is ${0} and your weekly rate is ${1}",hourlyRate ,weeklyRate);
             
            
        }
    }
}

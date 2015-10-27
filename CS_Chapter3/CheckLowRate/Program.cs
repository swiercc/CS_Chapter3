using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hourly Pay rate: ");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());

            if (hourlyRate < 5.65 )
                Console.Write("Error");
        }
    }
}

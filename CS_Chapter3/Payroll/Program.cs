using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {

            double tax;

            double net;

            Console.WriteLine("Hourly Pay rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours Worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            double gross = hourlyRate * hours;

            if (gross <= 300.00)
                tax = gross * .10;
            else
                tax = gross * .12;

            net = gross - tax;

            Console.WriteLine("Gross Pay: {0}   Witholding Tax: {1}   Net Pay: {2}"), gross , tax , net;
    

        }
    }
}

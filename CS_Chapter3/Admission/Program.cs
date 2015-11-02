using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Point Average:");
            double GPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Admission Test Score:");
            int score = Convert.ToInt32(Console.ReadLine());

            if ((GPA >= 3.0 && score >= 60) || GPA < 3.0 && score >= 80)
                Console.WriteLine("Accept");
            else
                Console.WriteLine("Reject");
        }
    }
}

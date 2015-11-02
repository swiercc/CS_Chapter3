using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter P for pine, O for oak, or M for mahogany.");
            string wood = Console.ReadLine();
            int price = 0;

            if (wood == "P")
                price = 100;
            if (wood == "O")
                price = 225;
            if (wood == "M")
                price = 310;

            Console.WriteLine("The price is ${0}.",price);

        }
    }
}

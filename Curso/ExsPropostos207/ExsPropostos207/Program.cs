using System;
using System.Globalization;

namespace ExsPropostos207
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stg = Console.ReadLine().Split(' ');
            double x = double.Parse(stg[0], CultureInfo.InvariantCulture);
            double y = double.Parse(stg[1], CultureInfo.InvariantCulture);

            if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }

            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

             else
                Console.WriteLine("Origem");
        }
    }
}
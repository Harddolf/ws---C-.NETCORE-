using System;
using System.Globalization;

namespace ExsPropostos208
{
    class Program
    {
        static void Main(string[] args)
        {
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;

            if (renda <= 2000.00)
            {
                Console.WriteLine("Insento.");

            }

            else if (renda <= 3000.00)
            {
                imposto = (renda - 2000) * 0.08;
                Console.WriteLine("R$: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (renda <= 4500.00)
            {
                imposto = (renda - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine("R$: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (renda > 4500)
            {
                imposto = (renda - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine("R$: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
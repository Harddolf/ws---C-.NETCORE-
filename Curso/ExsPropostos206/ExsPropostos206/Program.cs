using System;

namespace ExsPropostos206
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());

            if (valor == 0 && valor < 25)
            {
                Console.WriteLine($"Intervalo de [0,25]");
            }

            else if (valor > 25)
            {
                Console.WriteLine($"Intervalo de [25,50]");
            }

            else if (valor > 50 && valor < 75)
            {
                Console.WriteLine($"Intervalo de [50,75]");
            }

            else if (valor > 75 && valor == 100)
            {
                Console.WriteLine($"Intervalo de [75,100]");
            }
            else
                Console.WriteLine($"Fora de Intervalo");
        }
    }
}
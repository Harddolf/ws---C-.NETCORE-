using System;

namespace ExsPropostos205
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stg = Console.ReadLine().Split(' ');
            int codigo = int.Parse(stg[0]);
            double quantidade = double.Parse(stg[1]);
            double valor = 0;
            double preco = 0;

            if (codigo == 1)
            {
                preco = 4;
                valor = preco * quantidade;
                Console.WriteLine($"Total: R${valor}");
                return;
            }

            else if (codigo == 2)
            {
                preco = 4.5;
                valor = preco * quantidade;
                Console.WriteLine($"Total: R${valor}");
                return;
            }

            else if (codigo == 3)
            {
                preco = 5;
                valor = preco * quantidade;
                Console.WriteLine($"Total: R${valor}");
                return;
            }


            else if (codigo == 4)
            {
                preco = 2;
                valor = preco * quantidade;
                Console.WriteLine($"Total: R${valor}");
                return;
            }
            else
                preco = 1.5;
                valor = preco * quantidade;
                Console.WriteLine($"Total: R${valor}");
        }
    }
}
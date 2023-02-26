using System;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valorUnidade, valorTotal;

            Console.WriteLine("Digite o codigo do produto: ");
            codigo = int.Parse(Console.ReadLine());

            while (codigo > 0 & codigo < 5)
            {
                Console.WriteLine("Digite a quantidade: ");
                quantidade = int.Parse(Console.ReadLine());
                if (codigo == 1)
                {
                    valorUnidade = 4;
                    valorTotal = valorUnidade * quantidade;
                    Console.WriteLine($"Total R$ " + valorTotal.ToString("f2"));
                    break;
                }
                if (codigo == 2)
                {
                    valorUnidade = 4.5;
                    valorTotal = valorUnidade * quantidade;
                    Console.WriteLine($"Total R$ " + valorTotal.ToString("f2"));
                    break;
                }
                if (codigo == 3)
                {
                    valorUnidade = 5;
                    valorTotal = valorUnidade * quantidade;
                    Console.WriteLine($"Total R$ " + valorTotal.ToString("f2"));
                    break;
                }
                if (codigo == 4)
                {
                    valorUnidade = 2;
                    valorTotal = valorUnidade * quantidade;
                    Console.WriteLine($"Total R$ " + valorTotal.ToString("f2"));
                    break;
                }
                if (codigo == 5)
                {
                    valorUnidade = 1.5;
                    valorTotal = valorUnidade * quantidade;
                    Console.WriteLine($"Total R$ " + valorTotal.ToString("f2"));
                    break;
                }
            }
        }
    }
}
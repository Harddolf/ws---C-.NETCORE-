using System;

namespace ExsPropostos201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int numb = int.Parse(Console.ReadLine());

            if (numb < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }

        }
    }
}
using System;

namespace ExsPropostos202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int numb = int.Parse(Console.ReadLine());

            if (numb % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
                Console.WriteLine("IMPAR");
        }
    }

}

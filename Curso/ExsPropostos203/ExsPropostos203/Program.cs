using System;

namespace ExsPropostos203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string[] stg = Console.ReadLine().Split(" ");
            int valor01 = int.Parse(stg[0]); 
            int valor02 = int.Parse(stg[1]);
            if(valor01 % 2 == 0 && valor02 % 2 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
                Console.WriteLine("Não são multiplos");
        }
    }
}
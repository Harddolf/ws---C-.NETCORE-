using System;

namespace ExsPropostos301
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida. ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitivo.");
        }
    }
}
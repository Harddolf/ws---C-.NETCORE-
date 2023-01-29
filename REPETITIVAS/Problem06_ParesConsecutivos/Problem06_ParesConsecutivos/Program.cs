using System;
using System.Runtime.Serialization;

namespace Program
{
    class ParesConsecutivos
    {
        static void Main(string[] args)
        {
            int x, soma;

            Console.WriteLine("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            while(x != 0)
            {
                if(x % 2 != 0)
                {
                    x++;
                }
                soma = (x * 5) + 20;
                Console.WriteLine($"Soma = {soma}");
                Console.WriteLine("Digite um numero inteiro: ");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
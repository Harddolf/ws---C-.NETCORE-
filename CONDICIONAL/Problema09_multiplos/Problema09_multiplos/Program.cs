using System;
using System.Globalization;

namespace Programm
{
    class Multiplos 
    { 
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int numero1, numero2;

            Console.Write("Digite um numero qualquer: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um numero qualquer: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0) 
            {
                Console.WriteLine("São multiplos\n");
            }
            else
            {
                Console.WriteLine("Não são multiplos\n");
            }
        }
    
    }
}
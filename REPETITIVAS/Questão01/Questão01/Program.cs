using System;
using System.ComponentModel;
using System.Globalization;

namespace Quesao01
{
    class Program
    {
        static void Main(string[] args)
        {
            var CI = CultureInfo.InvariantCulture;
            int codigo1, codigo2, quantidade1, quantidade2; 
            double valor1, valor2, valorApagar;

            Console.WriteLine();
            codigo1 = int.Parse(Console.ReadLine());
            quantidade1 = int.Parse(Console.ReadLine());
            valor1 = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine();
            codigo2 = int.Parse(Console.ReadLine());
            quantidade2 = int.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine(), CI);

            valorApagar = (quantidade1 * valor1) + (quantidade2 * valor2);
            Console.WriteLine($"O valor a pagar é R$" + valorApagar.ToString("f2",CI) );

        }
    }
}
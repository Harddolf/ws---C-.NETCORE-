using System;
using System.Globalization;

namespace Questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            var CI = CultureInfo.InvariantCulture;
            double raio, area, pi = 3.14159;
            Console.WriteLine();
            raio = double.Parse(Console.ReadLine(), CI);
            area = pi * Math.Pow(raio, 2);
            //Na questão ele pede para considerar Pi = 3.14159, porém existe a função Math.PI que considera PI = 3.14159...
            //EX: area = Math.PI * Math.Pow(raio,2);
            Console.WriteLine($"A= "+area.ToString("f4",CI));
        }
    }
}
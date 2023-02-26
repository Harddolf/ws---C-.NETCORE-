using System;
using System.Globalization;
using System.Security.Authentication;

namespace Baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            var CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double X1 = (- b + Math.Sqrt(delta)) / (2 * a);
            double X2 = (- b - Math.Sqrt(delta)) / (2 * a);

            if (a == 0 && delta < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR!");
            }
            Console.WriteLine($"X1: {X1}");
            Console.WriteLine($"X2: {X2}");
        }
    }
}
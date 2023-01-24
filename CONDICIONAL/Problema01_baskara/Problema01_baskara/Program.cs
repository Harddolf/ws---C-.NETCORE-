using System;
using System.Globalization;

namespace Program
{
    class Baskara
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double coeficienteA, coeficienteB, coeficienteC, xr1, xr2, delta;

            Console.Write("Coeficiente a: ");
            coeficienteA = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            coeficienteB = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            coeficienteC = double.Parse(Console.ReadLine(), CI);

            delta = Math.Pow(coeficienteB, 2) - (4 * coeficienteA * coeficienteC);

            xr1 = (- coeficienteB + (Math.Sqrt(delta))) / (2 * coeficienteA);
            xr2 = (- coeficienteB - (Math.Sqrt(delta))) / (2 * coeficienteA);

            if (delta < 0)
            {
                Console.Write("Essa raiz é complexa, por favor utilize uma raiz REAL.");
            }
            else
            {
                Console.WriteLine("X1 = " + xr1.ToString("F4", CI));
                Console.WriteLine("X2 = " + xr2.ToString("F4", CI));
            }
            //Console.WriteLine(delta);



        }
    }
}

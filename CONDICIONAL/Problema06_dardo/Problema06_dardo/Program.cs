using System;
using System.Globalization;

namespace Program
{
    class Dardo
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double distancia1, distancia2, distancia3, maior;

            Console.WriteLine("Digite as 3 distancias: ");
            distancia1 = double.Parse(Console.ReadLine(),CI);
            distancia2 = double.Parse(Console.ReadLine(),CI);
            distancia3 = double.Parse(Console.ReadLine(),CI);

            if(distancia1 > distancia2 && distancia1 > distancia3)
            {
                maior = distancia1;
                Console.WriteLine("Maior distancia é: " + maior.ToString("F2", CI));
                Environment.Exit(0);
            }
            if(distancia2 > distancia1 && distancia2 > distancia3)
            {
                maior = distancia2;
                Console.WriteLine("Maior distancia é: " + maior.ToString("F2", CI));
                Environment.Exit(0);
            }

            maior = distancia3;
            Console.WriteLine("Maior distancia é: " + maior.ToString("F2", CI));

        }
    }
}
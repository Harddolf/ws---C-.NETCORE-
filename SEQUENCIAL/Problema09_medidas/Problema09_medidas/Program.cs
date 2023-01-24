using System;
using System.Globalization;

namespace Program
{
    class Medidas
    {
        static void Main(String[] args) 
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double medidaA, medidaB, medidaC, areaQuadrado, areaTriangulo, areaTrapezio;

            Console.Write("Digite a medida A: ");
            medidaA = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida B: ");
            medidaB = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida C: ");
            medidaC = double.Parse(Console.ReadLine(), CI);

            areaQuadrado = medidaA * medidaA;
            areaTriangulo = medidaA * medidaB / 2;
            areaTrapezio = ((medidaA + medidaB) * medidaC) / 2;

            Console.WriteLine("AREA DO QUADRADO: " + areaQuadrado.ToString("F4", CI));
            Console.WriteLine("AREA DO TRIANGULO: " + areaTriangulo.ToString("F4", CI));
            Console.WriteLine("AREA DO TRAPEZIO: " + areaTrapezio.ToString("F4", CI));

        }
    }
}
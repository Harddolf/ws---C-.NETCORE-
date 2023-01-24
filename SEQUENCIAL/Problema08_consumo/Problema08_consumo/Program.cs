using System;
using System.Globalization;

namespace Program
{
    class Consumo
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double distancia, combustivel, consumo;

            Console.Write("Distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine(), CI);

            Console.Write("Combustível: ");
            combustivel = double.Parse(Console.ReadLine(), CI);

            consumo = distancia / combustivel;

            Console.Write("O consumo medio foi de: " + consumo.ToString("F3", CI));

        }
    }
}
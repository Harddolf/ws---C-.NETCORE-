using System;
using System.Globalization;

namespace Program
{
    class Circulo
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double raio, area;

            Console.Write("Imforme o raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CI);

            area = Math.Pow(raio, 2) * Math.PI;
            
            Console.Write("AREA: " + area.ToString("F3", CI));
           


        }
    }
}
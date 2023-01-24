using System;
using System.Globalization;


namespace program
{
    class problema02_retangulo
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double Base, Altura, Area, Perimetro, Diagonal;

            Console.WriteLine("Base do retangulo: ");
            Base = double.Parse(Console.ReadLine(), CI);
            
            Console.WriteLine("Altura do retangulo: ");
            Altura = double.Parse(Console.ReadLine(), CI);
            
            Area = Base * Altura;

            Perimetro = 2 * (Base + Altura);

            Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0));
            

            Console.WriteLine("AREA: " + Area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO: " + Perimetro.ToString("F4", CI));
            Console.WriteLine("Diagonal: " + Diagonal.ToString("F4", CI));

        }
    }
}


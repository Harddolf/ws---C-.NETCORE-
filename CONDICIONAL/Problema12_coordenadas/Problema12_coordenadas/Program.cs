using System;
using System.Globalization;


namespace Program
{
    class Coordenadas
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double X, Y;

            Console.Write("Valor de X: ");
            X = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            Y = double.Parse(Console.ReadLine(), CI);

            if (X > 0 && Y > 0)
            {
                Console.Write("Q1");
            }
            if (X < 0 && Y > 0)
            {
                Console.Write("Q2");
            }
            if (X < 0 && Y < 0)
            {
                Console.Write("Q3");
            }
            if (X > 0 && Y < 0)
            {
                Console.Write("Q4");
            }
            if (X == 0 && Y == 0)
            {
                Console.Write("ORIGEM");
            }
            if (X == 0 && Y != 0)
            {
                Console.Write("Eixo Y");
            }
            if(X != 0 && Y == 0)
            {
                Console.Write("Eixo X");
            }
            {

            }
        }
    }
} 
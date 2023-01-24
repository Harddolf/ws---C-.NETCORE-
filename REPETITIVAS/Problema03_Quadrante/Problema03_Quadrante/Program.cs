using System;
using System.Globalization;

namespace Program
{
    class Quadrante
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante Q1");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Quadrante Q2");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante Q3");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quadrante Q4");
                }
                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Coordenada NULA!!");
        }
    }
}
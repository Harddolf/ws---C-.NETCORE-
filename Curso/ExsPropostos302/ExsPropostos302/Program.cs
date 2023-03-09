using System;

namespace ExsProposto302
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] espacoDeLinha = Console.ReadLine().Split(' ');
            int x = int.Parse(espacoDeLinha[0]);
            int y = int.Parse(espacoDeLinha[1]);

            while (x != 0 && y != 0)
            {
                
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante.");
                }

                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante.");
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante.");
                }

                else
                {
                    Console.WriteLine("Quarto Quadrante.");
                }

                espacoDeLinha = Console.ReadLine().Split(' ');
                x = int.Parse(espacoDeLinha[0]);
                y = int.Parse(espacoDeLinha[1]);
            }

        }
    }
}
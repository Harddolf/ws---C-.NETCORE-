using System;

namespace Program
{
    class MediaIdades
    {
        static void Main(string[] args)
        {
            float idades, mediaIdades, soma = 0;
            int quantidadeIdades = 0;

            Console.WriteLine($"Digite a Idade");
            idades = float.Parse(Console.ReadLine());
            
            if (idades < 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }

            if (idades >= 0)
            {
                while (idades >= 0)
                {
                    soma = idades + soma;
                    quantidadeIdades++;
                    Console.WriteLine($"Digite a Idade");
                    idades = float.Parse(Console.ReadLine());
                }
                mediaIdades = soma / quantidadeIdades;
                Console.WriteLine($"A media é: {mediaIdades}");
            }

        }
    }
}
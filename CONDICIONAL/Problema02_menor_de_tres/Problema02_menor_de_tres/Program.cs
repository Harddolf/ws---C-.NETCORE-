using System;
using System.Globalization;

namespace Program
{
    class Menor_de_tres
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int primeiro, segundo, terceiro, menor;

            Console.Write("Primeiro valor: ");
            primeiro = int.Parse(Console.ReadLine(), CI);
            Console.Write("Segundo valor: ");
            segundo = int.Parse(Console.ReadLine(), CI);
            Console.Write("Terceiro valor: ");
            terceiro = int.Parse(Console.ReadLine(), CI);
        
            if(primeiro < segundo && primeiro < terceiro)
            {
                menor = primeiro;
            }
            if(segundo < primeiro && segundo < terceiro)
            {

                menor = segundo;
            }
            else
            {
                menor = terceiro;
            }

            Console.WriteLine("MENOR: " + menor);
        }
    }
}
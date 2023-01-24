using System;
using System.Globalization;

namespace program
{
    class src
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double idade1, idade2, idade_media;
            string nome1, nome2;

            Console.WriteLine("Dados da primeira pesssoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pesssoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = double.Parse(Console.ReadLine());

            idade_media = (idade1 + idade2) / 2;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " é de " + idade_media.ToString("F1", CI) + " anos.");

        }
    }
}
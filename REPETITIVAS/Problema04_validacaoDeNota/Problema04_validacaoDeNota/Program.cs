using System;
using System.Globalization;

namespace Program
{
    class ValidacaoDeNota
    {
        static void Main(String[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double nota1 = 0, nota2 = 0, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);

            while(nota1 < 0  || nota1 > 10)
            {
                Console.WriteLine("NOTA INVALIDA!, DIGITE NOVAMENTE: ");
                nota1 = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            while (nota2 < 0 || nota2 > 10)
            {

                Console.WriteLine("NOTA INVALIDA!, DIGITE NOVAMENTE: ");
                nota2 = double.Parse(Console.ReadLine(), CI);
            }

            media = (nota1 + nota2) / 2;
            Console.WriteLine($"Sua media é: " + media.ToString("F2",CI));
        }
    }
}
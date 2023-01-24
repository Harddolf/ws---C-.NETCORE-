using System;
using System.Globalization;

namespace Program
{
    class notas
    {
        static void Main(String[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double nota1, nota2, notafinal;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            notafinal = (nota1 + nota2) / 2;

            if(notafinal < 60.0)
            {
                Console.WriteLine("REPROVADO!");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}

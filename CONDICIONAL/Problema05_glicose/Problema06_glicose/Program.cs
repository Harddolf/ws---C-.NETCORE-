using System;
using System.Globalization;

namespace Program
{
    class Glicose
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double glicose;

            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(), CI);

            if (glicose <= 100)
            {
                Console.WriteLine("Classificação: NORMAL");
            }
            if(glicose > 100 && glicose <= 140)
            {
                Console.WriteLine("Classificação: ELEVADO");
            
            }
            if (glicose > 140)
            {
                Console.WriteLine("Classificação: DIABETES");
            }
        }
    }

}

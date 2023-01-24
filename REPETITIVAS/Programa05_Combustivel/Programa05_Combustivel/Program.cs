using System;
using System.Globalization;

namespace Program
{
    class Combustivel
    {
        static void Main(string[] args)
        {
            int codigo, gasolina = 0, alcool = 0, diesel = 0;
            Console.WriteLine("Informe um codigo(1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());

            while(codigo !=4)
            {
                Console.WriteLine("Informe um codigo(1, 2, 3) ou 4 para parar: ");
                codigo= int.Parse(Console.ReadLine());

                if(codigo == 1)
                {
                    gasolina++;
                }
                if (codigo == 1)
                {
                    alcool++;
                }
                if(codigo == 3)
                {
                    diesel++;
                }
            }
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}






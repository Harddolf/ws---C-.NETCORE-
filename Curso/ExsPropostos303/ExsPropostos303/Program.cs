using System;

namespace ExsPropostos303
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = int.Parse(Console.ReadLine());
            int contadorAlcol = 0, contadorGasolina = 0, contadorDiesel = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    contadorAlcol++;
                }
                else if (codigo == 2)
                {
                    contadorGasolina++;
                }
                else if (codigo == 3)
                {
                    contadorDiesel++;
                }
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Alcool: {contadorAlcol} \r\nGasolina: {contadorGasolina} \r\nDiesel: {contadorDiesel}");
        }
    }
}
using System;
using System.Globalization;

namespace Program
{
    class Operadora
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int minutos;
            double valor;
            

            Console.Write("Digite a quantidades de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            valor = 50.00;

            if (minutos > 100)
            {
                valor = valor + (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CI));
        }
    }
}

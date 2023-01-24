using System;
using System.Globalization;

namespace Program
{
    class Lanchonete
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int codigo, quantidade;
            double produto1, produto2, produto3, produto4, produto5, valor;
            produto1 = 5.0;
            produto2 = 3.50;
            produto3 = 4.80;
            produto4 = 8.90;
            produto5 = 7.32;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            
            if(codigo == 1) 
            {
                valor = produto1 * quantidade;
                Console.Write("Valor a pagar: " + valor.ToString("F2", CI));
            }
            if (codigo == 2) 
            {
                valor = produto2 * quantidade;
                Console.Write("Valor a pagar: " + valor.ToString("F2", CI));
            }
            if (codigo == 3) 
            {
                valor = produto3 * quantidade;
                Console.Write("Valor a pagar: " + valor.ToString("F2", CI));
            }
            if (codigo == 4) 
            {
                valor = produto4 * quantidade;
                Console.Write("Valor a pagar: " + valor.ToString("F2", CI));
            }
            if (codigo == 5) 
            {
                valor = produto5 * quantidade;
                Console.Write("Valor a pagar: " + valor.ToString("F2", CI));
            }

        }
    }
}

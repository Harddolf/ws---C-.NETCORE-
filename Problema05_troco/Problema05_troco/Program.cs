using System;
using System.Globalization;

namespace Program
{
    class Troco
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double preço, recebido, troco;
            int quantidade;

            Console.Write("Preço unitário do produto: ");
            preço= double.Parse(Console.ReadLine());

            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            recebido = double.Parse(Console.ReadLine());

            troco = recebido - (preço * quantidade);
            
            Console.Write("O trco é: " + troco.ToString("F2", CI));
        }
    }
}

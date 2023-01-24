using System;
using System.Globalization;
using System.IO.IsolatedStorage;

namespace Program
{
    class Troco_verificado
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int quantidade_produto;
            double preco_do_uniproduto, dinheiro_recebido,total, troco, faltante;

            Console.Write("Preço unitario do produto: ");
            preco_do_uniproduto = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine();
            Console.Write("Quantidade comprada: ");
            quantidade_produto = int.Parse(Console.ReadLine(), CI);
            Console.WriteLine();
            Console.Write("Dinheiro recebido: ");
            dinheiro_recebido = double.Parse(Console.ReadLine(), CI);

            total = quantidade_produto * preco_do_uniproduto;
            troco = dinheiro_recebido - total;
             
            if (dinheiro_recebido < total)
            {
                faltante = total - dinheiro_recebido;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + faltante.ToString("F2", CI) + " REAIS.");
                Environment.Exit(0);
            }
            Console.WriteLine("TROCO: " + troco.ToString("F2", CI));
        }
    }
}

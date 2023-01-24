using System;
using System.Globalization;

namespace Program
{
    class Pagamento
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            string nome;
            double valorhora, horastrabalhadas, pagamento;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por hora: ");
            valorhora = double.Parse(Console.ReadLine(), CI);

            Console.Write("Horas trabalhadas: ");
            horastrabalhadas = double.Parse(Console.ReadLine(), CI);

            pagamento = valorhora * horastrabalhadas;

            Console.Write("O pagamento de " + nome + " deve ser " + pagamento.ToString("F2", CI));

        }
    }
}

using System;
using System.Globalization;

namespace Program
{
    class Aumento
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int porcentagem;
            double salario, novoSalario, aumento;

            Console.Write("Digite o salario da pessoa: ");
            salario = Convert.ToDouble(Console.ReadLine(),CI);

            if(salario <= 1000)
            {
                porcentagem = 20;
                novoSalario = salario + (0.2 * salario);
                aumento = novoSalario - salario;
                Console.Write("Novo salario: " + novoSalario.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Aumento de: " + aumento.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Porcentagem: " + porcentagem + "%.");
            }
            if (salario > 1000 && salario <= 3000)
            {
                porcentagem = 15;
                novoSalario = salario + (0.15 * salario);
                aumento = novoSalario - salario;
                Console.Write("Novo salario: " + novoSalario.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Aumento de: " + aumento.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Porcentagem: " + porcentagem + "%.");
            }
            if (salario > 3000 && salario <= 8000)
            {
                porcentagem = 10;
                novoSalario = salario + (0.1 * salario);
                aumento = novoSalario - salario;
                Console.Write("Novo salario: " + novoSalario.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Aumento de: " + aumento.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Porcentagem: " + porcentagem + "%.");
            }
            if (salario > 8000)
            {
                porcentagem = 5;
                novoSalario = salario + (0.05 * salario);
                aumento = novoSalario - salario;
                Console.Write("Novo salario: " + novoSalario.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Aumento de: " + aumento.ToString("F2", CI));
                Console.WriteLine();
                Console.Write("Porcentagem: " + porcentagem + "%.");
            }
        }
    }
}

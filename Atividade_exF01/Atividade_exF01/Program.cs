using System;
using System.Globalization;

namespace Atividade_exF01
{
    class exF
    {
        static void Main(string[] args) 
        { 
            CultureInfo CI = CultureInfo.InvariantCulture;
            string produto1 = "Computador", produto2 = "Mesa de Escritório";
            byte idade = 30;
            int codigo = 5290;
            char gener0 = 'M';
            double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

            Console.Write("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preoço é {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo}, e gênero: {gener0}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito cassa decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separar decimal invariant culture:" + medida.ToString("F3", CI));

        
        }
    
    }
}

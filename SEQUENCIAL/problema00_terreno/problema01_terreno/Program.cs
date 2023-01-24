//Problema "terreno"
//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma 
//casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida,
//o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com 
//duas casas decimais.

using System;
using System.Globalization;

namespace problema00_terreno
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double largura, comprimento, metroquadrado, area, preco;
           
            Console.WriteLine("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CI);
            
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CI);
            
            Console.WriteLine("Digite o valor do metro quadrado: ");
            metroquadrado = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimento;
            preco = area * metroquadrado;

            Console.WriteLine("Area do terreno: " + area.ToString("F2" , CI));
            Console.WriteLine("Preço do terreno: " + preco.ToString("F2", CI));

        }
    }
}
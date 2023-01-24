//Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes 
//números. 

using System;
using System.Globalization;

namespace program
{
    class soma
    {
        static void Main(string[] args)
        {
            double valor1, valor2, soma;

            Console.Write("Digite o valor 1: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            valor2 = double.Parse(Console.ReadLine());
            
            soma = valor1 + valor2;

            Console.WriteLine("A soma é: " + soma);

        }
                
    }
}
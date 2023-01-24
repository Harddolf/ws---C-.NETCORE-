using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace Program
{
    class Temperatura
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double celsius, fahrenheit;
            char escolhaTemperatura;

            Console.Write("Vôce vai digitar a temperatura em qual escala (C/F)? ");
            escolhaTemperatura = char.Parse(Console.ReadLine());

            if(escolhaTemperatura == 'C' || escolhaTemperatura == 'c')
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CI);

                fahrenheit = (celsius * 1.8) + 32;

                Console.WriteLine("Temperatura equivalente em Fahrenheit: " + fahrenheit.ToString("F2", CI));
                Environment.Exit(0);
            }
            if(escolhaTemperatura == 'F' || escolhaTemperatura == 'f')
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine(), CI);

                celsius = (fahrenheit - 32) / 1.8;

                Console.WriteLine("Temperatura equivalente em Celsius: " + celsius.ToString("F2", CI));
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("VALOR INEXISTENTE, POR FAVOR ESCOLHA ENTRE C OU F.");
            }
        }
    }
}
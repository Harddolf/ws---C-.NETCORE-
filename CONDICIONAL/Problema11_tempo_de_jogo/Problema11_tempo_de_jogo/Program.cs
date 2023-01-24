using System;
using System.Globalization;

namespace Program
{
    class TempoDeJogo
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int horaInicial, horaFinal, duracao;

            Console.Write("Hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial ;
            }
            else
            {
                duracao = 24 - (horaInicial - horaFinal); 
            }

            Console.WriteLine("O jogo durou " + duracao + " hora (S)");
        }
    }
}
using System;

namespace ExsPropostos204
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stg = Console.ReadLine().Split(' ');
            int hora01 = int.Parse(stg[0]);
            int hora02 = int.Parse(stg[1]);
            int horatotal = 0;

            if (hora02 > hora01)
            {
                horatotal = hora02 - hora01;
                Console.WriteLine($"O jogo durou: {horatotal}");
            }
            else
                horatotal = 24 - hora01 + hora02;
            Console.WriteLine($"O jogo durou: {horatotal}");
        }
    }
}




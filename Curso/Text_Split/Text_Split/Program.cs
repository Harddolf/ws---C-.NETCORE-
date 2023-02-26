using System;

namespace Text_Split
{
    // .Split Ex:
    class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Seu nome, idade e altura.");
            string[] text = Console.ReadLine().Split(" "); // É necessario usar um Vetor ex -> Var[] nome = ...Split(""); 
            string n1 = text[0];
            int n2 = int.Parse(text[1]);
            double n3 = double.Parse(text[2]);
            Console.WriteLine($"{n1} \r\n{n2} \r\n{n3}");
        }
    }
}
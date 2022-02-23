// See https://aka.ms/new-console-template for more information
using System;

namespace Ficha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("---MENU---");
            Console.WriteLine("1-Ex1");
            Console.WriteLine("2-Ex2");
            Console.WriteLine("3-Ex3");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Bem-Vindos ao C#");
                    break;
                case 2:
                    string word1 = "alunos", word2 = "bem vindos";
                    Console.WriteLine("Caros {0} sejam {1} ao C#", word1, word2);
                    break;
                case 3:

                    break;
                default:
                    Console.WriteLine("Erro");
                    Main();
                    break;
            }
        }

        void ex2()
        {
            Console.WriteLine("Bem-Vindos ao C#");
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System;

namespace Ficha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = menu();
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
                    ex3();
                    break;
                case 4:
                    ex4();
                    break;
                case 5:
                    ex5();
                    break;
                case 6:
                    ex6();
                    break;
                case 7:
                    ex7();
                    break;
                case 8:
                    ex8();
                    break;
                case 9:
                    ex9();
                    break;
                default:
                    Console.WriteLine("Erro");
                    Console.ReadKey(true);
                    Console.Clear();
                    menu();
                    break;
            }
        }

        static public int menu()
        {
            int op;
            Console.WriteLine("---MENU---");
            Console.WriteLine("1-Ex1");
            Console.WriteLine("2-Ex2");
            Console.WriteLine("3-Ex3");
            Console.WriteLine("4-Ex4");
            Console.WriteLine("5-Ex5");
            Console.WriteLine("6-Ex6");
            Console.WriteLine("7-Ex7");
            Console.WriteLine("8-Ex8");
            Console.WriteLine("9-Ex9");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static public void ex3()
        {
            Console.WriteLine("Ana ruivo".PadRight(20) + "Porto".PadRight(10));
            Console.WriteLine("Joaquim pinto".PadRight(20) + "Aveiro".PadRight(10));
            Console.WriteLine("Miguel costa".PadRight(20) + "Braga".PadRight(10));
            Console.ReadKey(true);
            Console.Clear();
            menu();
        }
        static public void ex4()
        {
            Console.WriteLine("Ana ruivo".PadLeft(20) + "Porto".PadLeft(10));
            Console.WriteLine("Joaquim pinto".PadLeft(20) + "Aveiro".PadLeft(10));
            Console.WriteLine("Miguel costa".PadLeft(20) + "Braga".PadLeft(10));
            Console.ReadKey(true);
            Console.Clear();
            menu();
        }
        static public void ex5()
        {
            Console.WriteLine("Ana ruivo\tPorto");
            Console.WriteLine("Joaquim pinto\tAveiro");
            Console.WriteLine("Miguel costa\tBraga");
            Console.ReadKey(true);
            Console.Clear();
            menu();
        }
        static public void ex6(){
            Console.WriteLine("4+3(15-2) = {0}", 4 + 3 * (15 - 2));
            Console.WriteLine("40:9 = {0}", 40/9);
            Console.WriteLine("40%3 = {0}", 40%3);
            Console.ReadKey(true);
            Console.Clear();
            menu();
        }
        public static void ex7()
        {
            Console.WriteLine("3^5 = {0}", Math.Pow(3, 5));
            Console.WriteLine("Sqrt(125) = {0}", Math.Sqrt(125));
            Console.WriteLine("20,49 com 0 casas decimais = {0}", Math.Round(20.49,0));
            Console.WriteLine("Sin(30) = {0}", Math.Sin(30));
            Console.ReadKey(true);
            Console.Clear();
            menu();
        }
        static public void ex8()
        {
            Console.WriteLine("A afirmaçao 4!=6 é {0}", 4 != 6);
            Console.WriteLine("A afirmaçao 4==5 é {0}", 4 == 5);
            Console.WriteLine("A afirmaçao 4>5 é {0}", 4 > 5);
            Console.WriteLine("A afirmaçao 4<5 && 6>10 é {0}", 4 < 5 && 6 > 10);
            Console.WriteLine("A afirmaçao 40<50 || 60>90 é {0}", 40 < 50 || 60 > 90);
            Console.WriteLine("A afirmaçao !(40<50 || 60>90) é {0}", !(40 < 50 || 60 > 90));
            Console.ReadKey(true);
            Console.Clear();
            menu();
        }
        static public void ex9()
        {
            Console.Clear();
            Console.WriteLine("1-Determine o comprimento de uma cadeia de caracteres");
            Console.WriteLine("2-Concatenar duas cadeias de caracteres");
            Console.WriteLine("3-Converta uma cadeia de caracteres em letras maiúsculas");
            Console.WriteLine("4-Extraia uma subcadeia de caracteres");
            Console.WriteLine("5-Determine a posição de início de uma subcadeia de caracteres");
            Console.WriteLine("6-Compare, em termos alfabéticos, duas cadeias de caracteres");
            Console.WriteLine("7-Elimine os espaços à esquerda e à direita de uma cadeia de caracteres");
            int op2 = Convert.ToInt16(Console.ReadLine());
            switch (op2)
            {
                case 1:
                    Console.WriteLine("Introduza uma frase: ");
                    string string1 = Console.ReadLine();
                    int stringlenght = string1.Length;
                    Console.WriteLine("A frase que introduziu contem {0} carateres", stringlenght);
                    break;
                case 2:
                    Console.WriteLine("Introduza uma string: ");
                    string string2 = Console.ReadLine();
                    Console.WriteLine("Introduza outra string: ");
                    string string3= Console.ReadLine();
                    Console.WriteLine("Resultado:\n{0} {1}",string2,string3);
                    break;
                case 3:
                    
                    break;
            }
        }
    }
}
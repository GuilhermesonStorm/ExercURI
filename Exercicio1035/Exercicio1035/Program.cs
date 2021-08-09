using System;

namespace Exercicio1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.WriteLine("Entre com um valor para A: ...");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um valor para B: ...");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um valor para C: ...");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um valor para D: ...");
            D = int.Parse(Console.ReadLine());

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos!");
            }
            else
            {
                Console.WriteLine("Valores não aceitos.");
            }
        }
    }
}

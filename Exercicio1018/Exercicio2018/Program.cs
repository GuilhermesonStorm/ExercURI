using System;

namespace Exercicio2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, cem, cinq, vint, dez, cinc, dois, um, resto;
            do
            {
                Console.WriteLine("Entre com um valor inteiro em dinheiro: ...");
                valor = int.Parse(Console.ReadLine());
            } while (valor <= 0);
            Console.WriteLine($"O valor digitado foi: {valor}");
            // Desenvolvimento da impressão
            cem = valor / 100;
            resto = valor % 100;
            cinq = resto / 50;
            resto = resto % 50;
            vint = resto / 20;
            resto = resto % 20;
            dez = resto / 10;
            resto = resto % 10;
            cinc = resto / 5;
            resto = resto % 5;
            dois = resto / 2;
            resto = resto % 2;
            um = resto;
            // Impressão
            Console.WriteLine($"{cem} nota(s) de 100.");
            Console.WriteLine($"{cinq} nota(s) de 50.");
            Console.WriteLine($"{vint} nota(s) de 20.");
            Console.WriteLine($"{dez} nota(s) de 10.");
            Console.WriteLine($"{cinc} nota(s) de 5.");
            Console.WriteLine($"{dois} nota(s) de 2.");
            Console.WriteLine($"{um} nota(s) de 1.");
        }
    }
}

using System;

namespace Exercicio1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;
            Console.WriteLine("Entre com uma distância em km: ...");
            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;
            Console.WriteLine($"O tempo para o carro Y tomar distância é: {tempo} minutos.");
        }
    }
}

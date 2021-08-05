using System;
using System.Globalization;

namespace ExercicioAleatorio1
{
    class Program
    {

        static void Main(string[] args)
        {
            int consumo = 12;
            int tempo;
            double vMedia;
            Console.WriteLine("Digite o tempo gasto na viagem: ...");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média: ...");
            vMedia = int.Parse(Console.ReadLine());
            Console.WriteLine($"A distância percorrida é: {tempo * vMedia}");
            Console.WriteLine($"O consumo de combustível será: {((tempo * vMedia) / consumo).ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}

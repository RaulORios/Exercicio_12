using System;
using System.Globalization;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 12     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            double temperatura;

            Console.Write("Informe a temperatura em FAHRENHEIT: ");
            temperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conversao = (temperatura - 32) / 1.8;

            Console.WriteLine("");

            Console.WriteLine($"A temperatura de {temperatura.ToString("F1",CultureInfo.InvariantCulture)}ºF em Graus Celsius é: {conversao.ToString("F1",CultureInfo.InvariantCulture)}ºC ");

            Console.ReadKey();



        }
    }
}

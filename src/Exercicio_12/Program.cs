using System;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo - Alterar a variável INT para Decimal. 

            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 12     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int temperatura;

            Console.Write("Informe a temperatura em FAHRENHEIT: ");
            temperatura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"A temperatura de {temperatura}ºF em Graus Celsius é: {(temperatura - 32) / 1.8}ºC ");

            Console.ReadKey();



        }
    }
}

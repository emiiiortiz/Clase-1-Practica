using System;

namespace PW3_2022_1C_Clase_1_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bievenidos a la calculadora");
            Console.WriteLine("Ingrese los numeros a sumer");

            Console.WriteLine("Num 1: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Num 2: ");
            string num2 = Console.ReadLine();

            int int1 = Int32.Parse(num1);
            int int2 = Int32.Parse( num2);

            Console.WriteLine($"{num1} + {num2} = {int1 + int2}");
            Console.ReadKey();

        }
    }
}

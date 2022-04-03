using PW3_2022_1C_Clase_1.Entidades;
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

         

            Console.WriteLine($"{num1} + {num2} = {Calculadora.Sumar(num1,num2)}");
            Console.ReadKey();

        }
    }
}

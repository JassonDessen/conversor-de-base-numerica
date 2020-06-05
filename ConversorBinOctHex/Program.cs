using System;
using System.Threading;
using ConversorBinOctHex.Services;

namespace ConversorBinOctHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Conversor de Binário, Octal e Hexadecimal");
            Console.WriteLine("Um conversor bem simples!");

            Console.WriteLine();

            try
            {
                Console.Write("Informe um número inteiro que não seja negativo: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Calculando...");
                Thread.Sleep(500);
                Console.WriteLine($"Binário: {Conversor.Binary(numero)}");
                Console.WriteLine($"Octal: {Conversor.Octal(numero)}");
                Console.WriteLine($"Hexadecimal: {Conversor.Hex(numero)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

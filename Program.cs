using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int valor2 = int.Parse(Console.ReadLine());

        int soma = valor1 + valor2;

        Console.WriteLine($"Soma = {soma}");
    }
}
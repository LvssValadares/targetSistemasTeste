using System;

class Program
{
    static bool VerificaFibonacci(int numero)
    {
        int a = 0, b = 1;
        while (a <= numero)
        {
            if (a == numero)
            {
                return true;
            }
            int temp = a;
            a = b;
            b = temp + b;
        }
        return false;
    }

    static void Main()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (VerificaFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci!");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();

        string invertedString = InvertString(input);

        Console.WriteLine($"String original: {input}");
        Console.WriteLine($"String invertida: {invertedString}");
    }

    static string InvertString(string str)
    {
        // Converte a string para um array de caracteres
        char[] characters = str.ToCharArray();

        // Inverte os caracteres manualmente
        for (int i = 0, j = characters.Length - 1; i < j; i++, j--)
        {
            // Troca os caracteres de posição
            char temp = characters[i];
            characters[i] = characters[j];
            characters[j] = temp;
        }

        // Converte o array de volta para string
        return new string(characters);
    }
}
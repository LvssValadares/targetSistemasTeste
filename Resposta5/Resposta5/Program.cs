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
        char[] characters = str.ToCharArray();

        for (int i = 0, j = characters.Length - 1; i < j; i++, j--)
        {
            char temp = characters[i];
            characters[i] = characters[j];
            characters[j] = temp;
        }

        return new string(characters);
    }
}
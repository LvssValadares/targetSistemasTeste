using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var faturamento = new Dictionary<string, decimal>
        {
            {"SP", 67836.43M},
            {"RJ", 36678.66M},
            {"MG", 29229.88M},
            {"ES", 27165.48M},
            {"Outros", 19849.53M}
        };

        decimal total = 0;
        foreach (var valor in faturamento.Values)
        {
            total += valor;
        }

        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine("--------------------------------------");
        foreach (var estado in faturamento)
        {
            decimal percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual.ToString("0.00")}%");
        }

        Console.WriteLine("\nVerificação:");
        decimal somaPercentuais = 0;
        foreach (var valor in faturamento.Values)
        {
            somaPercentuais += (valor / total) * 100;
        }
        Console.WriteLine($"Soma dos percentuais: {somaPercentuais.ToString("0.00")}%");
    }
}
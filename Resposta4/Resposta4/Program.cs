using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dados de faturamento por estado
        var faturamento = new Dictionary<string, decimal>
        {
            {"SP", 67836.43M},
            {"RJ", 36678.66M},
            {"MG", 29229.88M},
            {"ES", 27165.48M},
            {"Outros", 19849.53M}
        };

        // Calcula o faturamento total
        decimal total = 0;
        foreach (var valor in faturamento.Values)
        {
            total += valor;
        }

        // Calcula e imprime o percentual de cada estado
        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine("--------------------------------------");
        foreach (var estado in faturamento)
        {
            decimal percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual.ToString("0.00")}%");
        }

        // Verificação (a soma dos percentuais deve ser 100%)
        Console.WriteLine("\nVerificação:");
        decimal somaPercentuais = 0;
        foreach (var valor in faturamento.Values)
        {
            somaPercentuais += (valor / total) * 100;
        }
        Console.WriteLine($"Soma dos percentuais: {somaPercentuais.ToString("0.00")}%");
    }
}
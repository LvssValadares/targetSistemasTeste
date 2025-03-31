using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string jsonFilePath = "dados.json";
        string jsonString = File.ReadAllText(jsonFilePath);

        var dados = JsonSerializer.Deserialize<FaturamentoMensal>(jsonString);

        var faturamentos = dados.FaturamentoDiario
            .Where(d => d.Valor > 0)
            .Select(d => d.Valor)
            .ToList();

        if (faturamentos.Count == 0)
        {
            Console.WriteLine("Não houve faturamento no mês.");
            return;
        }

        double menor = faturamentos.Min();
        double maior = faturamentos.Max();
        double media = faturamentos.Average();
        int diasAcimaMedia = faturamentos.Count(v => v > media);

        Console.WriteLine($"Menor valor de faturamento: {menor}");
        Console.WriteLine($"Maior valor de faturamento: {maior}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
    }
}

public class FaturamentoDiario
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}

public class FaturamentoMensal
{
    public List<FaturamentoDiario> FaturamentoDiario { get; set; }
}
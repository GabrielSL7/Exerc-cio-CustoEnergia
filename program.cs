using System;

class Program
{
    static void Main()
    {
        Console.Write("Consumo em kWh/mês: ");
        double consumoMensal = double.Parse(Console.ReadLine());

        Console.Write("Horas de uso por dia: ");
        double horasPorDia = double.Parse(Console.ReadLine());

        double consumoDiario = consumoMensal / 30;
        double consumoPorHora = consumoDiario / horasPorDia;

        double custoPorKWh = 0.62258;
        double custoEstimado = consumoMensal * custoPorKWh;

        Console.WriteLine($"Custo estimado: R${custoEstimado:F6}");
    }
}

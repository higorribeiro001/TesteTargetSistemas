using System;

// questao 3
// considerando que 2024 tem 254 dias úteis
Random random = new Random();
List<decimal> billingDays = new List<decimal>();

for(int i=0; i<254; i++) {
    billingDays.Add((decimal)random.NextDouble() * 1000000);
}

decimal LowestValue(List<decimal> invoicing) {
    return invoicing.Min();
}

decimal GreaterValue(List<decimal> invoicing) {
    return invoicing.Max();
}

int DaysValueHigherThanAverage(List<decimal> invoicing) {
    decimal mean = invoicing.Sum()/invoicing.Count;
    int days = 0;
    foreach (int value in invoicing) {
        if (value > mean) {
            days++;
        }
    }

    return days;
}

Console.WriteLine($"Menor faturamento: {LowestValue(billingDays).ToString("c")}.");
Console.WriteLine($"Maior faturamento: {GreaterValue(billingDays).ToString("c")}.");
Console.WriteLine($"Números de dias em que o faturamento foi maior que a média anual: {DaysValueHigherThanAverage(billingDays)}.");

// Exemplo de resultado:
// Menor faturamento: R$ 812,87.
// Maior faturamento: R$ 999.458,98.
// Números de dias em que o faturamento foi maior que a média anual: 123.
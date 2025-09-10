// See https://aka.ms/new-console-template for more information
const double cotacaoDolar = 3.45;
Console.Write("Digite quanto dinheiro você tem na carteira (R$): ");
string input = Console.ReadLine();
if (double.TryParse(input, out double reais))
{
    double dolares = reais / cotacaoDolar;
    Console.WriteLine($"Com R${reais:F2}, você pode comprar US${dolares:F2}.");
}
else
{
    Console.WriteLine("Valor inválido. Por favor, digite um número.");
}
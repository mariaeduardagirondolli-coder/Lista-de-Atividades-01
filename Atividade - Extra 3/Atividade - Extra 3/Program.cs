// See https://aka.ms/new-console-template for more information
Console.Write("Digite o valor de A: ");
string inputA = Console.ReadLine();

Console.Write("Digite o valor de B: ");
string inputB = Console.ReadLine();

Console.Write("Digite o valor de C: ");
string inputC = Console.ReadLine();
if (double.TryParse(inputA, out double a) &&
               double.TryParse(inputB, out double b) &&
               double.TryParse(inputC, out double c))
{
    double delta = b * b - 4 * a * c;
    Console.WriteLine($"O valor de Δ (delta) é: {delta:F2}");
}
else
{
    Console.WriteLine("Valores inválidos. Por favor, digite números válidos.");
}

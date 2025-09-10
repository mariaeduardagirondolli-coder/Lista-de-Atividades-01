// See https://aka.ms/new-console-template for more information
Console.Write("Digite o preço do produto (R$): ");
string inputPreco = Console.ReadLine();
if (double.TryParse(inputPreco, out double preco))
{
    double precoPromocional = preco * 0.95;
    Console.WriteLine($"O preço promocional com 5% de desconto é: R${precoPromocional:F2}");
}
else
{
    Console.WriteLine("Valor inválido. Por favor, digite um número.");
}

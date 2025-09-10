// See https://aka.ms/new-console-template for more information
Console.Write("Digite a largura da parede em metros: ");
string larguraInput = Console.ReadLine();
Console.Write("Digite a altura da parede em metros: ");
string alturaInput = Console.ReadLine();
if (double.TryParse(larguraInput, out double largura) &&
                double.TryParse(alturaInput, out double altura))
{
    double area = largura * altura;
    double tintaNecessaria = area / 2.0;
    Console.WriteLine($"A área da parede é {area:F2} metros quadrados.");
    Console.WriteLine($"Quantidade de tinta necessária: {tintaNecessaria:F2} litros.");
}
else
{
    Console.WriteLine("Valores inválidos. Por favor, digite números válidos.");
}
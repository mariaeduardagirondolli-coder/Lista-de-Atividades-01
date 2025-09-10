// See https://aka.ms/new-console-template for more information
int valor1;
int valor2;
Console.WriteLine("Digite o primeiro valor");
valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
valor2 = int.Parse(Console.ReadLine());

if (valor1 > valor2)
{
    Console.WriteLine($"O maior valor é: {valor1}");
}

else if (valor2 > valor1)
{
    Console.WriteLine($"O valor maior é o {valor2}.");
}

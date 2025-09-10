// See https://aka.ms/new-console-template for more information
Console.Write("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
int valor3 = int.Parse(Console.ReadLine());

int maior;

// Comparações para encontrar o maior valor
if (valor1 >= valor2 && valor1 >= valor3)
{
    maior = valor1;
}
else if (valor2 >= valor1 && valor2 >= valor3)
{
    maior = valor2;
}
else
{
    maior = valor3;
}

Console.WriteLine($"O maior valor é: {maior}");

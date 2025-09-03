// See https://aka.ms/new-console-template for more information
int num1;
int num2;

Console.WriteLine("Digite um número: ")
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ")
num2 = int.Parse(Console.ReadLine());
int soma = num1 + num2;
Console.WriteLine($"A soma entre {num1} e {num2} é de {soma}");


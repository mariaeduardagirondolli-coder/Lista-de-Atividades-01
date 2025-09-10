// See https://aka.ms/new-console-template for more information
double nota1, nota2, media;

Console.WriteLine("Por favor, insira a nota da 1ª avaliação: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Por favor, insira a nota da 2ª avaliação: ");
nota2 = Convert.ToDouble(Console.ReadLine());
media = (nota1 + nota2) / 2;
Console.WriteLine($"A média aritmética das avaliações é: {media}");
if (media >= 6.0)
{
    Console.WriteLine("O aluno foi APROVADO!");
}
else
{
    Console.WriteLine("O aluno NÃO FOI APROVADO.");
}


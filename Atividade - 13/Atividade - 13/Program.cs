// See https://aka.ms/new-console-template for more information
int anoNascimento;
int anoAtual;
int idade;
Console.WriteLine("Escreva o ano atual: ");
anoAtual = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o do seu nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = anoAtual - anoNascimento;

if (idade < 16)
{
    Console.WriteLine("Você não pode votar");
}

else if ((idade >= 16 && idade <= 18 || idade >= 70))
{
    Console.WriteLine("Seu voto é facultativo");
}

else
{
    Console.WriteLine("Você é obrigado a votar.");
}

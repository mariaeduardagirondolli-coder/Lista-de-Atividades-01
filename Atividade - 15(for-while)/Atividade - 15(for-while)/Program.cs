// See https://aka.ms/new-console-template for more information
Console.WriteLine("Números entre 1000 e 2000 que deixam resto 5 quando divididos por 11:");

int i = 1000;
while (i <= 2000)
{
    if (i % 11 == 5)
    {
        Console.WriteLine(i);
    }
    i++;
}

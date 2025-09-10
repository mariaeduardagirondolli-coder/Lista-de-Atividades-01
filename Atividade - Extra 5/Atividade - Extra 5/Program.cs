// See https://aka.ms/new-console-template for more information
Console.Write("Digite o salário do funcionário: R$ ");
double salario = Convert.ToDouble(Console.ReadLine());
double aumento = salario * 0.15;
double novoSalario = salario + aumento;
Console.WriteLine("O novo salário do funcionário com 15% de aumento é: R$ " + novoSalario.ToString("F2"));

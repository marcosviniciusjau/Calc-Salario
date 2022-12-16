using System;

namespace DSCalculoDescontoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

double prestacao, salariobruto;
Console.WriteLine("Digite seu salário bruto");
salariobruto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da prestação");
prestacao = Convert.ToDouble(Console.ReadLine());

double trinta_porcento_salario = salariobruto * 0.3;

Console.WriteLine("30% de {0} é {1}", salariobruto, prestacao);

if (prestacao > trinta_porcento_salario)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Empréstimo NEGADO :( ");
}
else
    Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Empréstimo APROVADO :) ");
            
        }
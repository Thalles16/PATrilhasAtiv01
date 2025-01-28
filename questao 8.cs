using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário
        Console.WriteLine("Digite o preco do produto :");
        string entradaPreco = Console.ReadLine();
        double preco = Convert.ToDouble(entradaPreco);
        

        // Solicita a idade do usuário
        Console.WriteLine("Digite o desconto:");
        string entradadesconto = Console.ReadLine();
        double desconto = Convert.ToDouble(entradadesconto);
        
        
        double produto = (preco* desconto)/100;
        
        Console.WriteLine("o valor do produto com desconto é :"+produto);

        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

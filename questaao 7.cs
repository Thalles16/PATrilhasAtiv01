using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine();

        // Solicita a idade do usuário
        Console.WriteLine("Digite a sua idade:");
        int idade;

        // Tenta converter a idade para inteiro e verifica se é válida
        if (int.TryParse(Console.ReadLine(), out idade))
        {
            // Exibe as informações
            Console.WriteLine("Olá, "+nome+ "! Você tem "+idade+  " anos.");
        }
        else
        {
            // Trata entradas inválidas para a idade
            Console.WriteLine("Idade inválida. Por favor, reinicie o programa e insira uma idade válida.");
        }

        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

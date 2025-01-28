using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite 'sim' ou 'não':");
        string resposta = Console.ReadLine(); // Lê a entrada e trata o texto
        
        bool valorBool;

        // Verifica se a entrada é "sim" ou "não"
        if (resposta == "sim")
        {
            valorBool = true;
        }
        else if (resposta == "não")
        {
            valorBool = false;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Assumindo valor 'false'.");
            valorBool = false; // Valor padrão para entradas inválidas
        }

        // Exibe o valor booleano
        Console.WriteLine("O valor da variável bool é:" + valorBool);

        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

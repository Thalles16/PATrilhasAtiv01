using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário
        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();
        
        
Console.WriteLine("a palavra possui : " + palavra.Length + " letras");
        
        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um número real:");
        float numero;
        
        // Tenta converter a entrada para float
        if (float.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("O número digitado é: {numero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número real.");
        }

        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

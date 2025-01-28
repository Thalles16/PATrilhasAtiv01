using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero = int.Parse(Console.ReadLine());
		Console.Write("o numero digitado é " +numero);
		Console.Write(Console.ReadLine());
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
		
	}
}

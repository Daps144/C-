using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Iniciando preparo do sanduiche...");

        //Passo 1: Reunir ingredientes
        string[] ingredientes = { "Pão", "Queijo", "Presunto", "Complementos (opcional)" };
        Consloe.WriteLine("Reunindo ingredientes ": + string.Join(", ", ingredientes));

        //Passo 2: Montar o sanduiche
        Console.WriteLine("Pegando uma fatia de pão.");
        Console.WriteLine("Adicionando queijo.");
        Console.WriteLine("Adicionando presunto.");
        Console.WriteLine("Adicionando complementos, se desejado.");
        Console.WriteLine("Colocando a outra fatia de pão por cima.");

        //Passo 3: Finalizar e servir
        Console.WriteLine("Cortando o sanduiche ao meio.");
        Console.WriteLine("Colocando a outra fatia de pão por cima.");
        Console.WriteLine("Sanduiche pronto! Servindo...");

        Console.WriteLine("Fim do processo.");
          
    }
}
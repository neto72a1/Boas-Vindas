using System;

public class NomeCompleto
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;

        Console.WriteLine($"Nome completo: {nomeCompleto}");

        Console.ReadKey();
    }    
}

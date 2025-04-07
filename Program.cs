using System;

public class BoasVindas
{

    public static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        string mensagem = $"Olá, {nome}! Seja bem-vindo(a)!";

        Console.WriteLine(mensagem);

        Console.ReadKey();
    }
}
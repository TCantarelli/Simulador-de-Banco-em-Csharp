namespace Banco;
using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine();
        Console.WriteLine("Digite o nome da instituicao:");
        string instituicao = Console.ReadLine();
        Console.WriteLine("Digite a senha que deseja para sua conta OBS:  senha de apenas numeros e de ate 6 digitos:");
        string senha = Console.ReadLine();
        Console.WriteLine("Quanto de saldo inicial a conta vai ter?");
        double saldo =  Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Conta minhaConta = new Conta(titular, saldo, instituicao, senha);
        
        Terminal terminal = new Terminal(minhaConta);
    }
}
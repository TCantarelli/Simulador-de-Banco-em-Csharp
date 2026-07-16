namespace Banco;

public class Opcoes
{
    public static double valor;
    public Opcoes(string n, Conta conta)
    {
        
        switch (n)
        {
            case "1":
                Console.WriteLine($"saldo de {conta.Titular} eh de {conta.Saldo}");
                break;
            case "2":
                Console.WriteLine($"Digite um valor em Reais que deseja depositar em sua conta {conta.Titular}:");
                valor = Convert.ToDouble(Console.ReadLine());
                conta.depositar(valor);
                break;
            case "3":
                Console.WriteLine($"Digite a quantia que deseja sacar {conta.Titular}:");
                valor = Convert.ToDouble(Console.ReadLine());
                conta.saque(valor);
                break;
            case "4":
                conta.desbloquearConta();
                break;
            case "5" :
                Terminal.isRunning = false;
                Console.WriteLine($"Muito obrigado por usar o banco {conta.Instituicao}");
                return;
            default:
                Console.WriteLine("Opcao Invalida");
                break;
        }
    }

}
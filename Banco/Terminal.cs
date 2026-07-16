namespace Banco;

public class Terminal
{
    public static bool isRunning = true;
    public Terminal(Conta conta)
    {

        
        while (isRunning)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Digite qual operação deseja fazer:");
            Console.WriteLine("1) Consultar saldo");
            Console.WriteLine("2) Depositar dinheiro");
            Console.WriteLine("3) Retirar dinheiro");
            Console.WriteLine("4) Desbloquear Conta");
            Console.WriteLine("5) Sair");
            Console.WriteLine("==============================");
            string optionDesejada =  Console.ReadLine();
            Opcoes option = new Opcoes(optionDesejada, conta);
        }
    }
}
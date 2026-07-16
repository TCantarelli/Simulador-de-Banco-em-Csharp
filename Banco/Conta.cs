using System.Linq.Expressions;

namespace Banco;

public class Conta
{

    public bool block;
    private double _saldo;
    private string _titular;
    private string _instituicao;
    private string _senha; 



    public Conta(string titular, double saldo, string instituicao, string senha)
    {
        _titular = titular;
        _saldo = saldo;
        _instituicao = instituicao;
        _senha = senha;
        Instituicao =  instituicao;
        block = false;
    }

    public string Senha
    { 
        get { return _senha; }
        set { _senha = value; }
    }
    
    public double Saldo
    {
        get { return _saldo; }
        private set
        {
            _saldo = value;
        }
    }

    public string Titular
    {
        get { return _titular; }
        private set { _titular = value; }
    }

    public string Instituicao { get; private set; }

    public void mostrarSaldo()
    {
        Console.WriteLine($"O soldo da conta eh {Saldo}");
    }

    public void mostrarInstituicao()
    {
        Console.WriteLine($"a instituicao de conta eh na {Instituicao}");
    }
    public void mostrarTitularidade()
    {
        Console.WriteLine($"O titularidade da conta eh {_titular}");
    }

    public void depositar(double valor)
    {
        _saldo += valor;
        Console.WriteLine($"Deposito feito com sucesso!!");
    }

    public void saque(double valor)
    {
        if (block)
        {
            Console.WriteLine("Conta bloqueada!, va ate uma agencia desbloquear!");
            return;
        }
        if (valor > _saldo || valor < 0)
        {
            Console.WriteLine("Valor inserido para saque invalido");
            return;
        }
        string senha;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite sua senha para efetuar o saque {_titular}:");
            senha = Console.ReadLine();
            if (senha.Length <= 6)
            {
                if (senha == _senha)
                {
                    _saldo -= valor;
                    Console.WriteLine("Saque realizado com sucesso!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Senha incorreta, restam mais {4-i} tentativas");
                }

            }
            else
            {
                Console.WriteLine("Digite uma senha valida de ate 6 digitos");
                i--;
            }
        }
        Console.WriteLine("Conta bloqueada!");
        block = true;


    }

    public void desbloquearConta()
    {
        block = false;
        Console.WriteLine("Conta desbloqueada com sucesso!");
    }
    

}
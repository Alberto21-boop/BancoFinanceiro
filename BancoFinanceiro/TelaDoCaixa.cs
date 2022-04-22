using BancoFinanceiro;
using System;
using System.Globalization;


namespace TelaDoCaixa
{
    public static class TelaDoCaixa
    {
        public static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial s/n ; ");
            char resposta = char.Parse(Console.ReadLine());

            if(resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor do deposito inicial :");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Dados Da Conta");
            Console.WriteLine(conta);

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Entre com o valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Entre com o valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
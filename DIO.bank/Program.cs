using System;

namespace DIO.bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.pessoaFisica, 0, 0, "Hellen Mariane");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
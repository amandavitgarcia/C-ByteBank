using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class ContaCorrente
    {
        //Propriedade estatica da Classe
        public static int TotalContasCriadas { get; private set; } 



        public int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        public string conta;
        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente titular { get; set; }


        //Método Depositar
        public void Depositar(double valor) 
        {
            saldo += valor; 
        }

        //Método Sacar
        public bool Sacar(double saque) 
        {
            if (saque <= saldo)
            {
                saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método Transferir
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        //Métdo que exibe as informações das contas
        public void ExibirInformacoes()
        {
            Console.WriteLine("Numero_agencia: " + numero_agencia);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("titular: " + titular);
            Console.WriteLine("Saldo: " + saldo);
        }

        //Define o saldo (set)
        public void SetSaldo(double valor) 
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        //Obtém o saldo (get)
        public double GetSaldo() 
        {
            return this.saldo;
        }

        
        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = saldo + valor;
            }
        }
        

        //Definindo infos obrigatórias 
        public ContaCorrente(string titular, int numero_agencia, string numero_conta)
        {
            titular = titular;
            this.numero_agencia = numero_agencia;
            this.conta = numero_conta;
            TotalContasCriadas++;
        }
    }
}
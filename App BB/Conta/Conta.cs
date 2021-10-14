using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_BB
{
    class Conta
    {

        private string nome { get; set; }

        private double saldo { get; set; }

        private double Credito { get; set; }

        private TipoConta TipoConta { get; set; }

        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.Credito = credito;
            this.TipoConta = tipoConta;
        }

        //private para o desenvolvedor não alterar diretamente 


        public bool Sacar (double ValorSaque)
        {
            if(this.saldo - ValorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Sem saldo");
                return false;
            }
            this.saldo = this.saldo - ValorSaque;
            Console.WriteLine("O saldo atual da conta de {0} é {1}", this.nome, this.saldo);
            return true;
        }

        public  void Depositar(double ValorDeposito)
        {
            this.saldo = this.saldo + ValorDeposito;
            Console.WriteLine("O saldo atual da conta de {0} é {1}", this.nome, this.saldo);

        }

        public void Transferir(double ValorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(ValorTransferencia)) // vou pegar o metodo de saque e validar
                 // caso valide, passa para o proximo codigo
            {
                contaDestino.Depositar(ValorTransferencia);
            }

        }
        public override string ToString()
        {
            string retorno = " ";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.nome + " | ";
            retorno += "Saldo " + this.saldo + " | ";
            retorno += "Credito " + this.Credito + " | ";
            return retorno;
        }

    }
}

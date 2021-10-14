using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_BB
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {

             optionUser();
            string opcao = Console.ReadLine();

            while (opcao.ToUpper() != "X")
            {
              
                switch (opcao) {
                
                case "1":
                    ListarContas();
                    break;
                case "2":
                    InserirConta();
                    break;
                case "3":
                        transferir();
                    break;
                case "4":
                        VSacar();
                    break;
                case "5":
                        vdepositar();
                    break;
                    case "c":
                        Console.Clear();
                        break;
                    case "x":
                        break;

                }

                optionUser();
                opcao = Console.ReadLine();

            }
            Console.ReadLine();
        }
       
        public static void InserirConta()
        {
            Console.WriteLine("Inserir conta");
            Console.WriteLine("Insera o nome do cliente");
            string entradaNome = Console.ReadLine();
            Console.WriteLine("Digite 1 para conta fisica 2 para juridica");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo inicial");
            double entradaSaldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o crédito");
            double entradaCredito = double.Parse(Console.ReadLine());


            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta, saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);

            listContas.Add(novaConta);

        }


        public static void optionUser()
        {
            Console.WriteLine("Informe a opcao desejada");
            Console.WriteLine(" 1 " + "Listar contas");
            Console.WriteLine(" 2 " + "Inserir nova conta");
            Console.WriteLine(" 3 " + "Transferir");
            Console.WriteLine(" 4 " + "Sacar");
            Console.WriteLine(" 5 " + "Depositar");
            Console.WriteLine(" c " + "Limpar tela");
            Console.WriteLine(" x " + "Sair");






        }

        public static void transferir ( )
        {
            Console.WriteLine("Digite o numero da conta origem");
            int IdContaOrigin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da conta destino");
            int idContaDestino = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser transferido");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[IdContaOrigin].Transferir(valorTransferencia, listContas[idContaDestino]);

        }



        public static void ListarContas ()
        {

            Console.WriteLine("Listar contas");


            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return; // para sair deste metodo e não executar o for abaixo
            }
            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("# * " + i);
                Console.WriteLine(conta);


            }
        }



        public static void VSacar()
        {
            Console.WriteLine("Digite o numero da conta");
            int idConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do saque");
            double vsaque = double.Parse(Console.ReadLine());
            listContas[idConta].Sacar(vsaque);
        }

        public static void vdepositar ( )
        {
            Console.WriteLine("Digite o numero da conta");
            int idConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do deposito");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[idConta].Depositar(valorDeposito);
        }
    }
}

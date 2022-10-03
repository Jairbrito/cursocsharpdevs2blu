using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    internal class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }
        private void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista Recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Recepcionista: {Recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {Recepcionista.Nome}");
                Console.WriteLine($"CPF: {Recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {Recepcionista.Setor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        private void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }

        private void AlterarRecepcionista(Recepcionista Recepcionista)
        {
            var pact = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == Recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(pact);
            Program.Mock.ListaRecepcionistas[index] = Recepcionista;
        }

        private void ExcluirRecepcionista(Recepcionista Recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(Recepcionista);
        }
        private void ListarRecepcionistasByCodeAndName()
        {
            foreach (Recepcionista Recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.Write($"| {Recepcionista.CodigoRecepcionista} - {Recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }


        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("----- Cadastro de Recepcionistas -----");
            Console.WriteLine("----- 1- Lista de Recepcionistas -----");
            Console.WriteLine("----- 2- Cadastro de Recepcionistas -----");
            Console.WriteLine("----- 3- Alterar Recepcionistas -----");
            Console.WriteLine("----- 4- Deletar Recepcionistas -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarRecepcionistas();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista Recepcionista = new Recepcionista();
            Console.WriteLine("Informe o Nome do Recepcionista");
            Recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Recepcionista");
            Recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Setor do Recepcionista");
            Recepcionista.Setor = Console.ReadLine();

            Random rd = new Random();
            Recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            Recepcionista.CodigoRecepcionista = Int32.Parse($"{Recepcionista.Codigo}{rd.Next(100, 999)}");

            CadastrarRecepcionista(Recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista Recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o Recepcionista que Deseja Alterar:\n");
            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            Recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Recepcionista: {Recepcionista.Codigo}/{Recepcionista.CodigoRecepcionista} | Nome: {Recepcionista.Nome} | CPF: {Recepcionista.CGCCPF} | Setor: {Recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Setor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        Recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        Recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Setor:");
                        Recepcionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            AlterarRecepcionista(Recepcionista);
        }

        public void Excluir()
        {
            Recepcionista Recepcionista;
            Console.Clear();
            Int32 codigoRecepcionista;
            Console.WriteLine("Informe o ID do Medico Que Deseja Deletar:");
            ListarRecepcionistas();
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);
            Recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.Codigo == codigoRecepcionista);
            string opcaoExcluir;

            Console.WriteLine($"Codigo: {Recepcionista.Codigo} | Nome: {Recepcionista.Nome} |" +
                $" CPF: {Recepcionista.CGCCPF} Setor: {Recepcionista.Setor}");

            Console.WriteLine("Tem Certeza Que Deseja Deletar o Pacinte?");
            Console.WriteLine("01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.Clear();
                    Console.WriteLine("Recepcionista Deletado Com Sucesso!");
                    ExcluirRecepcionista(Recepcionista);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.Clear();
                    Console.WriteLine("Recepcionista Nao Deletado!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}

using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }
        private void ListarFornecedores()
        {
            Console.Clear();

            foreach (Fornecedor Fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Fornecedor: {Fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {Fornecedor.Nome}");
                Console.WriteLine($"Setor: {Fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        private void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }

        private void AlterarFornecedor(Fornecedor Fornecedor)
        {
            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == Fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = Fornecedor;
        }

        private void ExcluirFornecedor(Fornecedor Fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(Fornecedor);
        }
        private void ListarFornecedorsByCodeAndName()
        {
            foreach (Fornecedor Fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"| {Fornecedor.CodigoFornecedor} - {Fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }


        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("----- Cadastro de Fornecedors -----");
            Console.WriteLine("----- 1- Lista de Fornecedors -----");
            Console.WriteLine("----- 2- Cadastro de Fornecedors -----");
            Console.WriteLine("----- 3- Alterar Fornecedors -----");
            Console.WriteLine("----- 4- Deletar Fornecedors -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarFornecedores();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor Fornecedor = new Fornecedor();
            Console.WriteLine("Informe o Nome do Fornecedor");
            Fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Convênio do Fornecedor");
            Fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            Fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            Fornecedor.CodigoFornecedor = Int32.Parse($"{Fornecedor.Codigo}{rd.Next(100, 999)}");

            CadastrarFornecedor(Fornecedor);
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor Fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o Fornecedor que Deseja Alterar:\n");
            ListarFornecedorsByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            Fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Fornecedor: {Fornecedor.Codigo}/{Fornecedor.CodigoFornecedor} | Nome: {Fornecedor.Nome} | Convênio: {Fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CNPJ | 03 Tipo Fornecedor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        Fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        Fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Convênio:");
                        Fornecedor.TipoFornecedor = Console.ReadLine();
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

            AlterarFornecedor(Fornecedor);
        }

        public void Excluir()
        {
            Fornecedor Fornecedor;
            Console.Clear();
            Int32 codigoFornecedor;
            Console.WriteLine("Informe o ID do Medico Que Deseja Deletar:");
            ListarFornecedores();
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);
            Fornecedor = Program.Mock.ListaFornecedores.Find(p => p.Codigo == codigoFornecedor);
            string opcaoExcluir;

            Console.WriteLine($"Codigo: {Fornecedor.Codigo} | Nome: {Fornecedor.Nome} |" +
                $" CNPJ: {Fornecedor.CGCCPF} TipoFornecedor: {Fornecedor.TipoFornecedor}");

            Console.WriteLine("Tem Certeza Que Deseja Deletar o Pacinte?");
            Console.WriteLine("01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.Clear();
                    Console.WriteLine("Fornecedor Deletado Com Sucesso!");
                    ExcluirFornecedor(Fornecedor);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.Clear();
                    Console.WriteLine("Fornecedor Nao Deletado!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}

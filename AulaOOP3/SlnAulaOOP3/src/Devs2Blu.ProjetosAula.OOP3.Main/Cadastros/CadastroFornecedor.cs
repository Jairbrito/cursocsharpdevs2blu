using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enum;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    internal class CadastroFornecedor
    {
        public CadastroFornecedor()
        {

        }

        public void ManuCadastro()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine(@"            Cadastro Fornecedor          ");
                Console.WriteLine(@"         1 - Lista de Fornecedors        ");
                Console.WriteLine(@"       2 - Cadastro de Fornecedors       ");
                Console.WriteLine(@"          3 - Alterar Fornecedors        ");
                Console.WriteLine(@"          4 - Excluir Fornecedors        ");
                Console.WriteLine(@"   =================================");
                Console.WriteLine(@"                 0 - Sair              ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnum.LISTAR:
                        ListarFornecedores();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }

        public void ListarFornecedores()
        {
            Console.Clear();

            foreach (Fornecedor Fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {Fornecedor.Codigo}");
                Console.WriteLine($"Nome: {Fornecedor.Nome}");
                Console.WriteLine($"CPF: {Fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo do Fornecedor: {Fornecedor.TipoFornecedor}");
                Console.WriteLine(@"        =============");
            }
        }
        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }
        public void AlterarFornecedor()
        {

        }
        public void ExcluirFornecedor(Fornecedor Fornecedor)
        {

        }
    }
}


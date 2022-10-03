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
                    case (int)MenuEnum.CADASTRAR:
                        CadastrarFornecedor();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }

        public void ListarFornecedores()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {fornecedor.Codigo}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo do Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine(@"        =============");
            }
        }
        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {                
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {novoFornecedor.Codigo}");
                string codigo = Console.ReadLine();
                Console.WriteLine($"Nome: {novoFornecedor.Nome}");
                string nome = Console.ReadLine();
                Console.WriteLine($"CPF: {novoFornecedor.CGCCPF}");
                string cpf = Console.ReadLine();
                Console.WriteLine($"Tipo do Fornecedor: {novoFornecedor.TipoFornecedor}");
                string tipoFornecedor = Console.ReadLine();
                Console.WriteLine(@"        =============");
                Program.Mock.ListaFornecedores.Add(novoFornecedor);
            
        }
        public void AlterarFornecedor()
        {

        }
        public void ExcluirFornecedor(Fornecedor fornecedor)
        {

        }
    }
}


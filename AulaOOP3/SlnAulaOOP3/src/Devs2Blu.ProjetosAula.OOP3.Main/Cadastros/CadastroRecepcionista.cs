using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enum;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    internal class CadastroRecepcionista
    {
        public CadastroRecepcionista()
        {

        }

        public void ManuCadastro()
        {
            int opcao;
            do
            {
                Console.WriteLine(@"            Cadastro Recepcionista         ");
                Console.WriteLine(@"         1 - Lista de Recepcionista        ");
                Console.WriteLine(@"       2 - Cadastro de Recepcionista       ");
                Console.WriteLine(@"          3 - Alterar Recepcionista        ");
                Console.WriteLine(@"          4 - Excluir Recepcionista        ");
                Console.WriteLine(@"   =================================");
                Console.WriteLine(@"                 0 - Sair           ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnum.LISTAR:
                        ListarRecepcionistas();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }

        public void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista Recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {Recepcionista.Codigo}");
                Console.WriteLine($"Nome: {Recepcionista.Nome}");
                Console.WriteLine($"CPF: {Recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {Recepcionista.Setor}");
                Console.WriteLine(@"        =============");
            }
        }
        public void CadastrarRecepcionista()
        {

        }
        public void AlterarPaciente()
        {

        }
        public void ExcluirPaciente()
        {

        }
    }
}


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
    public class CadastroMedico
    {
        public CadastroMedico()
        {

        }

        public void ManuCadastro()
        {
            int opcao;
            do
            {
                Console.WriteLine(@"            Cadastro Medico         ");
                Console.WriteLine(@"         1 - Lista de Medico        ");
                Console.WriteLine(@"       2 - Cadastro de Medico       ");
                Console.WriteLine(@"          3 - Alterar Medico        ");
                Console.WriteLine(@"          4 - Excluir Medico        ");
                Console.WriteLine(@"   =================================");
                Console.WriteLine(@"                 0 - Sair           ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnum.LISTAR:
                        ListarMedicos();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }

        public void ListarMedicos()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedico)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {medico.Codigo}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine(@"        =============");
            }
        }
        public void CadastrarMedico()
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


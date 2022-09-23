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

        public void ManuCadastro(Mocks mocks)
        {
            int opcao;
            do
            {
                Console.WriteLine(@"            Cadastro Paciente          ");
                Console.WriteLine(@"         1 - Lista de Pacientes        ");
                Console.WriteLine(@"       2 - Cadastro de Pacientes       ");
                Console.WriteLine(@"          3 - Alterar Pacientes        ");
                Console.WriteLine(@"          4 - Excluir Pacientes        ");
                Console.WriteLine(@"   =================================");
                Console.WriteLine(@"                 0 - Sair              ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnum.LISTAR:
                        ListarPaciente(mocks);
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }

        public void ListarPaciente(Mocks mocks)
        {
            Console.Clear();

            foreach (Medico medico in mocks.ListaMedico)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine(@"        =============");
            }
        }
        public void CadastrarPaciente(Mocks mocks)
        {

        }
        public void AlterarPaciente(Mocks mocks)
        {

        }
        public void ExcluirPaciente(Mocks mocks)
        {

        }
    }
}


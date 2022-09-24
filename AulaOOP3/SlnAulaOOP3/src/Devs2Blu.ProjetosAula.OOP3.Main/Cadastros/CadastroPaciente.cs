using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enum;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public CadastroPaciente()
        {

        }

        public void ManuCadastro()
        {
            int opcao = 0;
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
                        ListarPaciente();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }

        public void ListarPaciente()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {paciente.Codigo}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenior: {paciente.Convenio}");
                Console.WriteLine(@"        =============");
            }
        }
        public void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }
        public void AlterarPaciente()
        {

        }
        public void ExcluirPaciente(Paciente paciente)
        {

        }
    }
}

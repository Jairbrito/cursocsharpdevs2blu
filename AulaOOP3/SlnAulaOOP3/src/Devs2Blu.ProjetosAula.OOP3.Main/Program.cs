using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enum;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            int opcao;
            Mock = new Mocks();
            do
            {
                Console.Clear();

                Console.WriteLine(@"            10 - Cadastro de Paciente           ");
                Console.WriteLine(@"             20 - Cadastro de Medicos           ");
                Console.WriteLine(@"          30 - Cadastro de Recepcionistas       ");
                Console.WriteLine(@"           40 - Cadastro de Fornecedores        ");
                Console.WriteLine(@"                     50 - Agenda                ");
                Console.WriteLine(@"                   60 - Prontuario              ");
                Console.WriteLine(@"                   70 - Financeiro              ");
                Console.WriteLine(@"================================================");
                Console.WriteLine(@"                      0 - Sair                  ");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnum.CAD_PAC:
                        CadastroPaciente moduloCadastroPacietes = new CadastroPaciente();
                        moduloCadastroPacietes.ManuCadastro();
                        break;
                    case (int)MenuEnum.CAD_MED:
                        CadastroMedico moduloCadastroMedico = new CadastroMedico();
                        moduloCadastroMedico.ManuCadastro();
                        break ;
                    case (int)MenuEnum.CAD_REC:
                        CadastroRecepcionista moduloCadastroRecepcionista = new CadastroRecepcionista();
                        moduloCadastroRecepcionista.ManuCadastro();
                        break;
                    case (int)MenuEnum.CAD_FOR:
                        CadastroFornecedor moduloCadastroFornecedor = new CadastroFornecedor();
                        moduloCadastroFornecedor.ManuCadastro();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnum.SAIR));
        }         
        

        /*public static void ViewListPaciente()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine(@"        =============");
                Console.WriteLine($"Codigo: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenior: {paciente.Convenio}");
                Console.WriteLine(@"        =============");
            }
        }*/
    }
}

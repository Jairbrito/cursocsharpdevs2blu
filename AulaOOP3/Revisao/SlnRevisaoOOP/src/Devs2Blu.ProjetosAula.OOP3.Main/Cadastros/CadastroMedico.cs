using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {

        }
        private void ListarMedicoss()
        {
            Console.Clear();

            foreach (Medico Medicos in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Medicos: {Medicos.CodigoMedico}");
                Console.WriteLine($"Nome: {Medicos.Nome}");
                Console.WriteLine($"CPF: {Medicos.CGCCPF}");
                Console.WriteLine($"CRM: {Medicos.CRM}");
                Console.WriteLine($"Especialidade: {Medicos.Especialidade}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        private void CadastrarMedicos(Medico novoMedicos)
        {
            Program.Mock.ListaMedicos.Add(novoMedicos);
        }

        private void AlterarMedicos(Medico Medicos)
        {
            var pact = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == Medicos.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(pact);
            Program.Mock.ListaMedicos[index] = Medicos;
        }

        private void ExcluirMedicos(Medico Medicos)
        {
            Program.Mock.ListaMedicos.Remove(Medicos);
        }
        private void ListarMedicossByCodeAndName()
        {
            foreach (Medico Medicos in Program.Mock.ListaMedicos)
            {
                Console.Write($"| {Medicos.CodigoMedico} - {Medicos.Nome} ");
            }
            Console.WriteLine("\n");
        }


        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("----- Cadastro de Medicoss -----");
            Console.WriteLine("----- 1- Lista de Medicoss -----");
            Console.WriteLine("----- 2- Cadastro de Medicoss -----");
            Console.WriteLine("----- 3- Alterar Medicoss -----");
            Console.WriteLine("----- 4- Deletar Medicoss -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarMedicoss();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Medico Medicos = new Medico();
            Console.WriteLine("Informe o Nome do Medico");
            Medicos.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Medico");
            Medicos.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe a Especialidade do Medico");
            Medicos.Especialidade = Console.ReadLine();

            Random rd = new Random();
            Random rd2 = new Random();
            Medicos.CRM = rd2.Next(rd.Next(300, 500));
            Medicos.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            Medicos.CodigoMedico = Int32.Parse($"{Medicos.Codigo}{rd.Next(100, 999)}");

            CadastrarMedicos(Medicos);
        }

        public void Alterar()
        {
            Console.Clear();
            Medico Medicos;
            int codigoMedicos;

            Console.WriteLine("Informe o Medicos que Deseja Alterar:\n");
            ListarMedicossByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedicos);

            Medicos = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedicos);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Medicos: {Medicos.Codigo}/{Medicos.CodigoMedico} | Nome: {Medicos.Nome} | CPF: {Medicos.CGCCPF} | Convênio: {Medicos.Especialidade}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Especialidade | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        Medicos.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        Medicos.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe uma nova Especialidade:");
                        Medicos.Especialidade = Console.ReadLine();
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

            AlterarMedicos(Medicos);
        }

        public void Excluir()
        {
            Medico Medicos;
            Console.Clear();
            Int32 codigoMedicos;
            Console.WriteLine("Informe o ID do Medico Que Deseja Deletar:");
            ListarMedicoss();
            Int32.TryParse(Console.ReadLine(), out codigoMedicos);
            Medicos = Program.Mock.ListaMedicos.Find(p => p.Codigo == codigoMedicos);
            string opcaoExcluir;

            Console.WriteLine($"Codigo: {Medicos.Codigo} | Nome: {Medicos.Nome} |" +
                $" CPF: {Medicos.CGCCPF} Convenio: {Medicos.Especialidade}");

            Console.WriteLine("Tem Certeza Que Deseja Deletar o Pacinte?");
            Console.WriteLine("01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.Clear();
                    Console.WriteLine("Medicos Deletado Com Sucesso!");
                    ExcluirMedicos(Medicos);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.Clear();
                    Console.WriteLine("Medicos Nao Deletado!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}

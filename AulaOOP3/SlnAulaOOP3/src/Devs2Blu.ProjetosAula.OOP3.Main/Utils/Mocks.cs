using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public  List<Paciente> ListaPacientes { get; set; }
        public  List<Medico> ListaMedico { get; set; }
        public  List<Recepcionista> ListaRecepcionistas { get; set; }
        public  List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedico = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPaciente();
            CargaMedico();
            CargaRecepcionista();
            CargaFornecedor();
        }

        public void CargaPaciente()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedico()
        {
            String[] especialidade = { "Humano", "Jogador", "Caro", "ET" };
            Random rand = new Random();
            for (int i = 1; i < 4; i++)
            {              
                Medico medico = new Medico(i, $"Medico {i + 1}", $"{i}23{i}56{i}891{i}", rand.Next(380, 890), especialidade[rand.Next(0, 4)]);
                ListaMedico.Add(medico);
            }
        }


        public void CargaRecepcionista()
        {
            string[] recep = { "Bancario", "Atendimento ao cliente", "Infantil", "Operacional" };
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i + 2}", $"{i}23{i}56{i}891{i}", recep[random.Next(0, 4)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaFornecedor()
        {
            string[] recep = { "Renauxview", " Hudtelfa" };
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i + 10}", $"{i}23{i}56{i}891{i}", recep[random.Next(0, 2)]);
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}

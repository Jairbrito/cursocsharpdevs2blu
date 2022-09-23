using Devs2Blu.ProjetosAula.OOP3.Models.Model;
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
            string[] especialidade = new string[3] { "1", "2", "3" };

            for (int i = 1; i < 5; i++)
            {
                Medico medico = new Medico(i, $"Medico {i}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaMedico.Add(medico);
            }
        }

    }
}

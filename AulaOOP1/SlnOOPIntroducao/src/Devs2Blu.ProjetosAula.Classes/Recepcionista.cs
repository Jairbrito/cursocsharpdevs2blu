using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {
        public static int CodigoConsulta { get; set; }
        public int NumeroCracha { get; set; }
        public Recepcionista() 
        {
            Nome = "Novo";
            SobreNome = "Recepcionista";
            NumeroCracha = 99999999;
        }
        public Recepcionista(string nome, string sobreNome) 
        {
            this.Nome = nome;
            this.SobreNome = sobreNome;
        }
        public Recepcionista(int numeroCracha, string endereco)
        {
            NumeroCracha = numeroCracha;
            Enderoco = endereco;
        }
        public string AgendarConsulta()
        {
            return $"Consulta Agendada!";
        }
    }
}

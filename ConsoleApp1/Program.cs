using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatacaoDados = "Inizializacao de Variavel... \n";
            string nomeUsuario, cidadeUsuario;

            //nomeUsuario = "jair";
            Console.Write("Informe seu nome de Usuario: ");
            nomeUsuario = Console.ReadLine();
            
            Console.Write("Informe sua cidade: ");
            cidadeUsuario = Console.ReadLine();
            
            //Console.WriteLine("Seja bemvindo, " + nomeUsuario + " ;) ");
            formatacaoDados += "Seja bemvindo, " + nomeUsuario + " ;\n\n";
            formatacaoDados += $"Localidade: {cidadeUsuario}";
            Console.WriteLine(formatacaoDados);

            Console.WriteLine("Prescione qualquer tecla");
            var input = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Devs2Blu.ProjetosAula.Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            const string A21 = "A21";
            const string A22 = "A22";
            const string A23 = "A23";
            const string A24 = "A24";
            const string A35 = "A35";
            const string Z16 = "Z16";
            string codigo;    
            Console.WriteLine("Informe um Codigo");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case A21:
                case A22:
                case A23:
                case A24:
                    Console.WriteLine("Materiais");
                    break;
                case A35:
                    Console.WriteLine("A35: Produtos Pereciveis");
                    break;
                case Z16:
                    Console.WriteLine("Z16: Produtos Quimicos");
                    break;
                default:
                    Console.WriteLine("Produto Invalido");
                    break;
            }
            */

            //Const emplementacao futura//
            /*string fruta;
            Console.WriteLine("Informe uma fruta\n");
            Console.WriteLine("Maca");
            Console.WriteLine("Kiwi");
            Console.WriteLine("Melancia");

            fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case "MACA":
                    Console.WriteLine("Não vendemos esta fruta aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            */

            //Const emplementacao futura//
            /*string modeloCarros;
            Console.WriteLine("|***** Nossos modelos de carro *****|\n");
            Console.WriteLine("Hacth");
            Console.WriteLine("Sedans");
            Console.WriteLine("Motocicletas");
            Console.WriteLine("Caminhonetes");

            modeloCarros = Console.ReadLine();

            switch (modeloCarros.ToLower())
            {
                case "hacth":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case "sedans":
                case "motocicletas":
                case "caminhonetes":
                    Console.WriteLine("Tem certeza que não prefere este modelo");
                    break;
                default:
                    Console.WriteLine("Nao trabalhamos com este tipo de automovel aqui");
                    break;
            }
            */


            const int sete = 7;
            const int quartoze = 14;
            const int vinte_um = 21;

            int jogadorPlus, cpu, numJogador, resultJogador, resultCpu;
            Console.WriteLine(@"                |***** Jogo do 21 *****|");
            Console.WriteLine();
            Console.WriteLine(@"             Infome um numero entre 1 a 20");
            string jogador = Console.ReadLine();
            Int32.TryParse(jogador, out numJogador);
     
            Random rd = new Random();
            jogadorPlus = rd.Next(1, 20);
            cpu = rd.Next(1, 20);

            resultJogador = numJogador + jogadorPlus;
            resultCpu = cpu + jogadorPlus;

            if(resultJogador >= 1 && resultJogador <=6)
            {
                Console.WriteLine("A pontucao do jogador foi : 1 pts\n");
            }else if (resultJogador >=8 && resultJogador <= 13)
            {
                Console.WriteLine("A pontucao do jogador foi : 5 pts\n");
            }else if (resultJogador >=15 && resultJogador <= 20)
            {
                Console.WriteLine("A pontucao do jogador foi : 6 pts\n");
            }


            switch (resultJogador)
            {
                case sete:
                    Console.WriteLine("A pontucao do jogador foi : 10 pts\n");
                    break;
                case quartoze:
                    Console.WriteLine("A pontucao do jogador foi : 20 pts\n");
                    break;
                case vinte_um:
                    Console.WriteLine("A pontucao do jogador foi : 30 pts\n");
                    break;
                default:
                    Console.WriteLine("Pontucao...\n");
                    break;
            }

            if (resultCpu >= 1 && resultCpu <= 6)
            {
                Console.WriteLine("A pontucao do CPU foi : 1 pts\n");
            }
            else if (resultCpu >= 8 && resultCpu <= 13)
            {
                Console.WriteLine("A pontucao do CPU foi : 5 pts\n");
            }
            else if (resultCpu >= 15 && resultCpu <= 20)
            {
                Console.WriteLine("A pontucao do CPU foi : 6 pts\n");
            }


            switch (resultCpu)
            {
                case sete:
                    Console.WriteLine("A pontucao do CPU foi : 10 pts\n");
                    break;
                case quartoze:
                    Console.WriteLine("A pontucao do CPU foi : 20 pts\n");
                    break;
                case vinte_um:
                    Console.WriteLine("A pontucao do CPU foi : 30 pts\n");
                    break;
                default:
                    Console.WriteLine("Pontucao...\n");
                    break;
            }

            Console.WriteLine($"O numero das cartas Jogaor foi: {resultJogador}\n");
            Console.WriteLine($"O numero das cartas CPU foi: {resultCpu}\n");
            Console.WriteLine($"O numero da mesa: {jogadorPlus}");
            
        }
    }
}

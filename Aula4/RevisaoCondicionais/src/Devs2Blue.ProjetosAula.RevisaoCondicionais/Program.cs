using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blue.ProjetosAula.RevisaoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            Console.WriteLine("Seja Bem-vindo ao programa locao!\n\n");
            Console.WriteLine("Escolha o programa desejado: ");
            Console.WriteLine("1 - Exemplo 1");
            Console.WriteLine("2 - Exemplo 2");
            Console.WriteLine("3 - Exemplo 3");
            Console.WriteLine("4 - Exemplo 4");
            Console.WriteLine("5 - Exemplo 5");
            Console.WriteLine("-------------");
            Console.WriteLine("0 - Sair");
            string optSTR = Console.ReadLine();
            Int32.TryParse(optSTR, out opcao);

            if(opcao == 1)
            {
                Exemplo1();
            }else if(opcao == 2)
            {
                Exemplo2();
            }else if (opcao == 3)
            {
                Exemplo3();
            }
            else if (opcao == 4)
            {
                Exemplo4();
            }
            /*else if (opcao == 5)
            {
                Exemplo5();
            }*/
            else if (opcao == 0)
            {
                Console.WriteLine("| Bye |");
            }

        }

        static void Exemplo1()
        {
            Console.Clear();
            Console.WriteLine("*** Programa Exemplo 1 ***\n");
            Console.WriteLine("Gerar 2 Numeros Aleatorios (0 - 100)\n");
            Console.WriteLine("Mostra o maior numero\n");
            int numero, numero1;

            Random rd = new Random();
            numero = rd.Next(0, 100);
            numero1 = rd.Next(0, 100);
            Console.WriteLine($"Numero 1 = {numero}");
            Console.WriteLine($"Numero 2 = {numero1}");

            if(numero > numero1)
            {
                Console.WriteLine($"Numero 1 e o maior. Numero1 = {numero}\n");
            }else if(numero1 > numero)
            {
                Console.WriteLine($"Numero 2 e o maior. Numero2 = {numero1}\n");
            }
            else
            {
                Console.WriteLine($"Os numeros sao iguais! Numeros = {numero} e {numero1}\n");
            }

        }
        static void Exemplo2()
        {

            Console.Clear();
            Console.WriteLine("*** Programa Exemplo 2 ***");
            Console.WriteLine("Gerar 3 numeros aleatorios");
            Console.WriteLine("Escrevelos em ordem crescente");
            int numero, numero1, numero2;
            string formatacaoTextoSaida = "";

            Random rd = new Random();
            numero = rd.Next(0, 100);
            numero1 = rd.Next(0, 100);
            numero2 = rd.Next(0, 100);

            if(numero > numero1 && numero > numero2)
            {
                formatacaoTextoSaida += $"{numero}, ";
                if(numero1 > numero2)
                {
                    formatacaoTextoSaida += $"{numero1}, {numero2},";
                }
                else
                {
                    formatacaoTextoSaida += $"{numero2}, {numero1},";
                }
            }else if(numero1 > numero && numero1 > numero2)
            {
                formatacaoTextoSaida += $"{numero2},";
                if(numero > numero2)
                {
                    formatacaoTextoSaida += $"{numero}, {numero2},";
                }
                else
                {
                    formatacaoTextoSaida += $"{numero2}, {numero},";
                }
            }
            else
            {
                formatacaoTextoSaida += $"{numero2}, ";
                if(numero > numero1)
                {
                    formatacaoTextoSaida += $"{numero}, {numero2}";
                }
                else
                {
                    formatacaoTextoSaida += $"{numero1}, {numero},";
                }
            }

            Console.WriteLine($"Ordem de saida: {formatacaoTextoSaida}");

        }
        static void Exemplo3()
        {
            Console.Clear();
            int idade;
            bool permissao;
            string nome;

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            string inputIdade = Console.ReadLine();
            Int32.TryParse(inputIdade, out idade);

            permissao = (idade > 17) ? true : false;

            if (permissao)
            {
                Console.WriteLine($"Seja bem-vindo, {nome}! (+18)");
            }
            else
            {
                Console.WriteLine("Idade insuficiente");
            }

        }
        static void Exemplo4()
        {
            Console.Clear();
            int idade, tempoTrabalho;

            Random rd = new Random();

            idade = rd.Next(18, 80);
            tempoTrabalho = rd.Next(15, 40);

            if((idade > 25) || (tempoTrabalho > 25))
            {
                Console.WriteLine($"Idade {idade}\n");
                Console.WriteLine($"Tempo trabalho {tempoTrabalho}\n");
                Console.WriteLine("Pessoa pode se aposentar!");
            }
            else
            {
                Console.WriteLine($"Idade {idade}\n");
                Console.WriteLine($"Tempo trabalho {tempoTrabalho}\n");
                Console.WriteLine("Lamentamos, mas ainda nao pode se aposentar.");
            }

        }

    }
}

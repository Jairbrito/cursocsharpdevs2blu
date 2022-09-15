using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Swtch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*const string A1 = "A1";
            const string A2 = "A2";
            const string A3 = "A3";
            int num1, num2, result; 
            Console.WriteLine(@"        Calc em Switch");
            Console.WriteLine("Escolha o metodo");
            Console.WriteLine("A1_Menos. - ");
            Console.WriteLine("A2_Adicao. + ");
            Console.WriteLine("A3_Divisao. / \n");
            string operacao = Console.ReadLine();

            Console.WriteLine("Informe um numero: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Informe o segundo numero: ");
            Int32.TryParse(Console.ReadLine(), out num2);

            switch (operacao.ToUpper())
            {
                case A1:
                    result = (num1 - num2);
                    Console.WriteLine($"O resultado e: {result}");
                    break;
                case A2:
                    result = (num1 + num2);
                    Console.WriteLine($"O resultado e: {result}");
                    break;
                case A3:
                    result = (num1 / num2);
                    Console.WriteLine($"O resultado e: {result}");
                    break;
                default:
                    break;
            }*/


            /*const string A1 = "A1";
            const string A2 = "A2";
            const string A3 = "A3";
            Console.WriteLine(@"        Tipos de Produtos");
            Console.WriteLine("A1 - Produtos Não-perecíveis");
            Console.WriteLine("A2 - Frutas");
            Console.WriteLine("A3 - Bebidas");
            string tipoProduto = Console.ReadLine();
            Console.Clear();
            
            switch (tipoProduto.ToUpper())
            {
                case A1:
                    Console.WriteLine(@"        Escolha o produto");
                    Console.WriteLine("B1 - Arroz");
                    Console.WriteLine("B2 - Feijao");
                    Console.WriteLine("B3 - Cafe");
                    string isso = Console.ReadLine();
                    if (isso == "B1")
                    {
                        Console.WriteLine("O seu Produto e Arroz");
                    }else if (isso == "B2")
                    {
                        Console.WriteLine("O seu Produto e Feijao");
                    }else if(isso == "B3")
                    {
                        Console.WriteLine("O seu Produto e Cafe");
                    }
                    break;
                case A2:
                    Console.WriteLine(@"        Escolha o produto");
                    Console.WriteLine("C1 - Manga");
                    Console.WriteLine("C2 - Banana");
                    Console.WriteLine("C3 - Maca");
                    string isso1 = Console.ReadLine();
                    if (isso1 == "C1")
                    {
                        Console.WriteLine("O seu Produto e Manga");
                    }
                    else if (isso1 == "C2")
                    {
                        Console.WriteLine("O seu Produto e Banana");
                    }
                    else if (isso1 == "C3")
                    {
                        Console.WriteLine("O seu Produto e Maca");
                    }
                    break;
                case A3:
                    Console.WriteLine(@"        Escolha o produto");
                    Console.WriteLine("D1 - Leite");
                    Console.WriteLine("D2 - Sucos");
                    Console.WriteLine("D3 - Refrigerantes");
                    string isso2 = Console.ReadLine();
                    if (isso2 == "D1")
                    {
                        Console.WriteLine("O seu Produto e Leite");
                    }
                    else if (isso2 == "D2")
                    {
                        Console.WriteLine("O seu Produto e Sucos");
                    }
                    else if (isso2 == "D3")
                    {
                        Console.WriteLine("O seu Produto e Refrigerantes");
                    }
                    break;
                default:
                    Console.WriteLine("Produto nao encontrado");
                    break;
            }*/

            int controle = 0;

            do
            {
                Console.WriteLine("Informe um dos códigos Abaixo\n");
                Console.WriteLine("1 - Exemplo1");
                Console.WriteLine("2 - Exemplo2");
                Console.WriteLine("3 - Exercicio1");
                Console.WriteLine("4 - Exercicio2");
                Console.WriteLine("5 - Exercicio3");
                Console.WriteLine("6 - Exercicio4");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exercicio1();
                        break;
                    case 4:
                        Exercicio2();
                        break;
                    case 5:
                        Exercicio3();
                        break;
                    case 6:
                        Exercicio4();
                        break;
                    default:
                        break;
                }

            } while (controle > 0);
        }

        static void Exemplo1()
        {
            int controle = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair\n");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }

        static void Exemplo2()
        {
            Console.WriteLine("Exemplo 2");
        }

        static void Exercicio1()
        {

            int contador = 1;
            Console.WriteLine("Numeros impares de 1 ate 100");
            while (contador <=100) 
            {
                Console.Write($"{contador}, ");
                contador = contador + 2;
            }
        }

        static void Exercicio2()
        {

            int contador = 1;
            Console.WriteLine("Numeros pares de 1 ate 100");
            while (contador <= 100)
            {
                if(contador %2 == 0)
                {
                    Console.Write($"{contador}, ");
                }
                contador++;
            }
        }
        static void Exercicio3()
        {

            int contador = 1;
            int limit;
            Console.WriteLine("Numeros pares e impares de 1 ate 100");
            Console.WriteLine("Informe um numero (1 - 100)");
            Int32.TryParse(Console.ReadLine(), out limit);
            Console.WriteLine(@"                Numeros Impares");
            Console.Write("Numeros Pares");
            while (contador <= limit)
            {
                if (contador % 2 == 0)
                {
                    Console.Write($"{contador}\n");
                }else if (contador % 2 != 0){
                    Console.Write($"\t\t{contador}\n");
                }
                contador++;
            }
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("|*** Sistema Média ***|\n\n");
            Console.Write("Quantos alunos tem na sala: ");
            Int32.TryParse(Console.ReadLine(), out int qtdAlunos);
            int i = 1;
            float notas, soma = 0;
            do
            {
                Console.Write($"Digite a nota do {i}º aluno: ");
                float.TryParse(Console.ReadLine(), out notas);
                soma += notas;
                i++;
            } while (i <= qtdAlunos);
            float media = soma / qtdAlunos;
            Console.WriteLine($"A média de nota da turma = {media:F2}");
        }

    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Atividade2e2();
        }

        static void Atividade2e2()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = 999999999;

            Console.WriteLine("Programa que verifica qual o menor valor entre quatro valores \n\n");

            Console.WriteLine("Informar o Valor 1");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.WriteLine("Informar o Valor 2");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.WriteLine("Informar o Valor 3");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.WriteLine("Informar o Valor 4");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if(valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if (valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.WriteLine($"O menor valor e {menorValor}");

        }

        static void Atividade2()
        {
            int valor1, valor2, valor3, valor4;

            Console.WriteLine("Programa que verifica qual o menor valor entre quatro valores \n\n");

            Console.WriteLine("Informar o Valor 1");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.WriteLine("Informar o Valor 2");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.WriteLine("Informar o Valor 3");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.WriteLine("Informar o Valor 4");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if(valor1 < valor2 &&  
                valor1 < valor3 && 
                valor1 < valor4)
            {
                Console.WriteLine($"Valor 1 ({valor1}) e o menor!");
            }else if(valor2 < valor3 &&
                        valor2 < valor4)
            {
                Console.WriteLine($"Valor 2 ({valor2}) e o menor!");
            }else if (valor3 < valor4)
            {
                Console.WriteLine($"Valor 3 ({valor3}) e o menor!");
            }
            else
            {
                Console.WriteLine($"Valor 4 ({valor4})e o menor!");
            }

        }
      }

    /* static void Atividade1()
    {
        ////    ATIVIDADE 1 PROFESSOR   ////
        int primeiroValor, segundoValor;
        Console.WriteLine("Mostra o Maior Valor Entre os Informados!\n\n");

        Console.WriteLine("Informe o primeiro valor: ");
        string vl1Str = Console.ReadLine();
        Int32.TryParse(vl1Str, out primeiroValor);

        Console.WriteLine("Informe o primeiro valor: ");
        string vl2Str = Console.ReadLine();
        Int32.TryParse(vl2Str, out segundoValor);

        if (primeiroValor > segundoValor)
        {
            Console.WriteLine($"O primeiro valor e maior! {primeiroValor}");
        }
        else if (segundoValor < primeiroValor)
        {
            Console.WriteLine($"O segundo valor e maior! {segundoValor}");
        }
        else
        {
            Console.WriteLine("Sao iguais");
        }
        /* ////
         *  ATIVIDADE 1  // IF/ELSE // 
         *
        int number1,number2;
        Console.WriteLine("Escreva um numero: ");
        string number = Console.ReadLine();

        Console.WriteLine("Escreva o segundo numero: ");
        string number0 = Console.ReadLine();

        number1 = Int16.Parse(number);
        number2 = Int16.Parse(number0);

        if (number1 < number2)
        {
            Console.WriteLine(number0);
        }else
        {
            Console.WriteLine(number);
        }*/

    /*static void Exemplo1()
    {
        string textoSaida;
        string nomeCandidato;
        int idade, nota;

        Console.WriteLine("|***** Bem vindo ao Programa SysSchool *****|\n\n");

        Console.WriteLine("Informe o Nome do Candidato: ");
        nomeCandidato = Console.ReadLine();

        Console.WriteLine("Informe a Idade do Candidato: ");
        string idadeSTR = Console.ReadLine();

        if (idadeSTR.Equals(""))
        {
            Console.WriteLine("Valor invalido para Idade!");
            return;
        }
        else
        {
            idade = Int32.Parse(idadeSTR);
        }

        Console.WriteLine("Informe a Nota do Candidato: ");
        string notaSTR = Console.ReadLine();

        if (notaSTR.Equals(""))
        {
            Console.WriteLine("Valor invalido para Nota!");
            return;
        }
        else
        {
            nota = Int32.Parse(notaSTR);
        }

        //Formatacao

        textoSaida = $"Candidato: {nomeCandidato}\n";
        textoSaida += $"Idade: {idade}\n";

        if (idade < 18)
        {
            textoSaida += ("Menor de idade\n");
        }
        else
        {
            textoSaida += ("Maior de idade\n");
        }

        textoSaida += $"Nota Final: {nota}\n\n";

        if (nota > 5)
        {
            textoSaida += @"************
*APROVADO*
************";
        }
        else
        {
            textoSaida += "| REPROVADO |";
        }

        Console.WriteLine(textoSaida);
    }*/

}

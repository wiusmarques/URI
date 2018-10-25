/*
 * URI Online Judge | 1240 https://www.urionlinejudge.com.br/judge/pt/problems/view/1240
 * Encaixa ou Não I
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */


using System;
using System.IO;

namespace URI.MATEMATICA
{
    class _1240
    {
        private int quantidadeIteracoes;
        private string entrada, numA, numB;
        StreamWriter sw = new StreamWriter("saida.txt");

        public _1240()
        {
            startProcess();
        }

        private void startProcess()
        {
            quantidadeIteracoes = int.Parse(Console.ReadLine());
            

            for (int a = 0; a < quantidadeIteracoes; a++)
            {

                entrada = Console.ReadLine();
                numA = entrada.Split(' ')[0];
                numB = entrada.Split(' ')[1];

                if (numB.Length > numA.Length)
                {
                    sw.WriteLine("nao encaixa");
                    Console.WriteLine("nao encaixa");
                }
                else
                {
                    int indexInicial = numA.Length - numB.Length;
                    int tamanhoTotal = numB.Length;

                    if (numB.Equals(numA.Substring(indexInicial, tamanhoTotal)))
                    {
                        sw.WriteLine("encaixa");
                        Console.WriteLine("encaixa");
                    }
                    else
                    {
                        sw.WriteLine("nao encaixa");
                        Console.WriteLine("nao encaixa");
                    }
                }
            }

            sw.Close();
        }
    }
}

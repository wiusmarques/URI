/*
 * URI Online Judge | 1221 https://www.urionlinejudge.com.br/judge/pt/problems/view/1221
 * Primo Rápido
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;
using System.IO;

namespace URI.MATEMATICA
{
    class _1221
    {

        private int quantidadeIteracoes;
        private Boolean isPrime = true;
        private UInt32 dividendo, range, divisor;

        //ESSE ARQUIVO SERÁ CRIADO APENAS PARA ANALISARMOS A SAÍDA PARA CONFERÊNCIA
        private StreamWriter sw = new StreamWriter("saida.txt");

        public _1221()
        {
            startProcess();
        }

        private void startProcess()
        {
            quantidadeIteracoes = int.Parse(Console.ReadLine());

            for (int a = 0; a < quantidadeIteracoes; a++)
            {
                //COLETA DO NOSSO DIVIDENDO. É O NÚMERO O QUAL IREMOS ANALISAR SE É OU NÃO PRIMO
                dividendo = UInt32.Parse(Console.ReadLine());

                //DOIS E TRÊS SÃO PRIMOS E JÁ SERÃO ANALISADO PARA DESCARTA-LOS
                if (dividendo == 2 || dividendo == 3)
                {
                    sw.WriteLine("Prime");
                    Console.WriteLine("Prime");
                }
                //SABEMOS QUE 1 E TODOS OS NÚMEROS PARES NÃO PODEM SER PRIMOS PORTANTO OS DESCARTAREMOS
                else if (dividendo < 2 || dividendo % 2 == 0)
                {
                    sw.WriteLine("Not Prime");
                    Console.WriteLine("Not Prime");
                }
                //INCLUIMOS O 5 E O 7 COMO NÚMEROS PRIMOS
                else if (dividendo < 9)
                {
                    sw.WriteLine("Prime");
                    Console.WriteLine("Prime");
                }
                //NENHUM MULTIPLO DE TRÊS É PRIMO, PORTATO OS DESCARTAREMOS AQUI
                else if (dividendo % 3 == 0)
                {
                    sw.WriteLine("Not Prime");
                    Console.WriteLine("Not Prime");
                }
                //NENHUMA DAS ALTERNATIVAS ACIMA SENDO ATENDIDA IREMOS PERCORRER OS CANDIDATOS A DIVISOR DA MELHOR
                //MANEIRA POSSÍVEL.
                else
                {
                    /*
                    * SETAREMOS NOSSO LIMITE COMO SENDO A RAIZ QUADRADA DO DIVIDENDO, OS NÚMEROS QUE VIRÃO DEPOIS DA RAIZ DO DIVIDENDO
                    * JÁ FORAM TESTADOS PELOS NÚMEROS ATERIORES DA CONTAGEM QUE O MÚLTIPLICAM PARA CHEGAR AO VALOR DO DIVIDENDO
                    */

                    range = (UInt32)Math.Ceiling((Math.Sqrt(dividendo)));
                    divisor = 5;

                    while (divisor <= range)
                    {

                        if (dividendo % divisor == 0 || dividendo % (divisor + 2) == 0)
                        {
                            sw.WriteLine("Not Prime");
                            Console.WriteLine("Not Prime");
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                        }

                        //O CONTADOR SOMANDO DE SEIS EM SEIS GARATIRARÁ QUE PASSEMOS POR TODOS OS NÚMEROS RESTATES 
                        //A SE VERIFICAR DETRO DO NOSSO RANGE
                        divisor += 6;

                    }

                    // NOSSO DIVIDENDO NÃO ATENDENDO AS CONDIÇÕES ACIMA TERÁ SEU "ISPRIME" COMO TRUE FINALIZANDO O PROCESSO
                    if (isPrime)
                    {
                        sw.WriteLine("Prime");
                        Console.WriteLine("Prime");
                    }

                }
            }
            sw.Close();
        }
    }
}
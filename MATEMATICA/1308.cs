/*
 * URI Online Judge | 1308 https://www.urionlinejudge.com.br/judge/pt/problems/view/1308
 * Guerreiros Etruscos Nunca Jogam Xadrez
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */
using System;
using System.IO;

namespace URI.MATEMATICA
{
    class _1308
    {
        private double quantidadeIteracoes;
        private double C, raizDelta, raizEquacao;
        private const int A = 1;
        private const int B = 1;

        //IREMOS UTILIZAR 
        private StreamWriter sw = new StreamWriter("saida.txt");

        public _1308()
        {
            startProcess();
        }

        private void startProcess()
        {
            /*
             * NESTE EXERCÍCIO TEMOS A SOMA DOS TERMOS DE UMA PROGRESSÃO ARITMÉTICA PORTANTO TRABALHAREMOS COM A FORMULA S = ( n(n + 1) ) / 2
             * COMO QUEREMOS SABER O ÚLTIMO NÚMERO DA SEQUÊNCIA SABENDO QUE TEMOS APENAS UM VALOR APROXIMADO DO SOMATÓRIO TOTAL IREMOS TRABALHAR 
             * COM A EQUAÇÃO n² + n - S = 0;
             */
            quantidadeIteracoes = double.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeIteracoes; i++)
            {
                // O "C" DA NOSSA EQUAÇÃO SEMPRE SERÁ NEGATIVO, ELE SERÁ O VALOR APROXIMADO DO SOMATÓRIO TOTAL
                C = -1 * (double.Parse(Console.ReadLine()) * 2);

                // CALCULANDO DELTA
                raizDelta = Math.Sqrt(Math.Pow(B, 2) - 4 * A * C);

                // PEGANDO APENAS A RAÍZ POSITIVA DA EQUAÇÃO, A RAIZ É O VALOR DE N
                raizEquacao = (((-1 * B) + raizDelta) / 2 * A);
                
                //EXIBINDO E ARMAZENANDO AS SAÍDAS PARA ANÁLISE
                sw.WriteLine(Math.Floor(raizEquacao));
                Console.WriteLine(Math.Round(raizEquacao));
            }

            sw.Close();
        }
    }
}

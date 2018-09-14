/*
 * URI Online Judge | 1169 https://www.urionlinejudge.com.br/judge/pt/problems/view/1169
 * Trigo no Tabuleiro
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.MATEMATICA
{
    class _1169
    {
        
        private int quantidadeQuadradosTabuleiro;
        private Double totalGraos = 0;
        private UInt64 quilosTotais = 0;

        public _1169()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            int totalCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCasos; i++)
            {
                quantidadeQuadradosTabuleiro = int.Parse(Console.ReadLine());

                //PARA CALCULAR UTILIZANDO POTÊNCIA DE DOIS DEVEMOS LEVAR EM CONSIDERAÇÃO QUE O PRIMEIRO QUADRADO DO TABULEIRO 
                //INICIARÁ COM 1 GRÃO E DEVERÁ SER SOMADO AO RESTANTE DA POTÊNCIA DE DOIS PARA TORNAR O RESULTADO CORRETO.

                totalGraos = Math.Pow(2, quantidadeQuadradosTabuleiro) + 1;
                quilosTotais = (UInt64)Math.Floor(totalGraos / 12 / 1000);
                Console.WriteLine(quilosTotais + " kg");

            }
        }
    }
}

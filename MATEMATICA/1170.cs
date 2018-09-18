/*
 * URI Online Judge | 1170 https://www.urionlinejudge.com.br/judge/pt/problems/view/1170
 * Blobs
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.MATEMATICA
{
    class _1170
    {

        int quantidadeCasosTeste;
        double estoqueTotal;
        int duracaoTotalDoEstoque = 0;

        public _1170()
        {
            quantidadeCasosTeste = int.Parse(Console.ReadLine());
            StratProcess();
        }

        private void StratProcess()
        {
            for (int a = 0; a < quantidadeCasosTeste; a++)
            {
                estoqueTotal = double.Parse(Console.ReadLine());

                if (estoqueTotal <= 1.0)
                {
                    Console.WriteLine("0 dias");
                }
                else
                {
                    while (true)
                    {
                        estoqueTotal = estoqueTotal * 0.5;

                        if (estoqueTotal <= 1)
                        {
                            duracaoTotalDoEstoque++;
                            Console.WriteLine(duracaoTotalDoEstoque + " dias");
                            break;
                        }

                        duracaoTotalDoEstoque++;
                    }
                    duracaoTotalDoEstoque = 0;
                }
            }
        }
    }
}

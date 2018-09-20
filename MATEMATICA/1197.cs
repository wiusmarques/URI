/*
 * URI Online Judge | 1197 https://www.urionlinejudge.com.br/judge/pt/problems/view/1197
 * Volta à Faculdade de Física
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.MATEMATICA
{
    class _1197
    {
        private string entrada;
        private int v, t;

        public _1197()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            
            while (true)
            {
                entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    //EOF
                    break;
                }

                v = int.Parse(entrada.Split(' ')[0]);
                t = int.Parse(entrada.Split(' ')[1]);

                Console.WriteLine(v * t * 2);
            }
        }
    }
}

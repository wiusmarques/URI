/*
 * URI Online Judge | 1007 https://www.urionlinejudge.com.br/judge/pt/problems/view/1007
 * Diferença
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.INICIANTE
{
    class _1007
    {
        private int a, b, c, d;

        public _1007()
        {
            StartProces();
        }

        private void StartProces()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("DIFERENCA = " + (a * b - c * d));
        }
    }
}

/*
 * URI Online Judge | 1001 https://www.urionlinejudge.com.br/judge/pt/problems/view/1001
 * Extremamente Básico
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlool.com
 */
using System;
namespace URI.INICIANTE
{
    class _1001
    {
        
        private int a, b, x;

        public _1001(string a,string b)
        {
            this.a = this.setA(a);
            this.b = this.setB(b);
            somar();
        }

        private int setA(string a)
        {
            return int.Parse(a);
        }

        private int setB(string b)
        {
            return int.Parse(b);
        }

        private void somar()
        {
            this.x = this.a + this.b;
        }

        public void printResultFormat()
        {
            Console.WriteLine(string.Format("X = {0}", x));
        }

    }
}

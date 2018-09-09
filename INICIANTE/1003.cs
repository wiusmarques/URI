/*
 * URI Online Judge | 1003 https://www.urionlinejudge.com.br/judge/pt/problems/view/1003
 * Soma Simples
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.INICIANTE
{
    class _1003
    {
        private int a, b;
        private string result;

        public _1003(string a, string b)
        {
            this.setA(a);
            this.setB(b);
            this.somar();
        }

        private void setA(string a)
        {
            this.a = int.Parse(a);
        }

        private void setB(string b)
        {
            this.b = int.Parse(b);
        }

        private void somar()
        {
            this.result = (a + b).ToString();
        }

        public void resultado()
        {
            Console.WriteLine(string.Format("SOMA = {0}", this.result));
        }

    }
}

/*
 * URI Online Judge | 1004 https://www.urionlinejudge.com.br/judge/pt/problems/view/1004
 * Produto Simples
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;
namespace URI.INICIANTE
{
    class _1004
    {
        private int primeiroValor, segundoValor, resultadoProduto;
        private string resultadoString;

        public _1004(string a, string b)
        {
            setA(a);
            setB(b);
            calcularProduto();
        }

        private void setA(string a)
        {
            primeiroValor = int.Parse(a);
        }

        private void setB(string b)
        {
            segundoValor = int.Parse(b);
        }

        private void calcularProduto()
        {
            resultadoProduto = primeiroValor * segundoValor;
        }

        public void resultado()
        {
            resultadoString = string.Format("Prod = {0}", resultadoProduto);
            Console.WriteLine(resultadoString);
            Console.ReadKey();
        }

    }
}

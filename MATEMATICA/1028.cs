/*
 * URI Online Judge | 1028 https://www.urionlinejudge.com.br/judge/pt/problems/view/1028
 * Figurinhas
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlool.com
 */

using System;

/*PARA ESSE EXERCÍCIO IREI UTILIZAR A GRADE DE EUCLIDES*/

namespace URI.MATEMATICA
{
    class _1028
    {


        private String entrada;
        private int qtdInteracoes;
        private int valorA, valorB, buffer, resposta;

        public _1028(string qtdInteracoes)
        {
            setQtdInteracoes(qtdInteracoes);
            aplicarGradeDeEuclides();
        }

        private void setQtdInteracoes(string qtdIteracoes)
        {
            this.qtdInteracoes = int.Parse(qtdIteracoes);
        }

        private void setValores(string valores)
        {
            setValorA(valores.Split(' ')[0]);
            setValorB(valores.Split(' ')[1]);
        }

        private void setValorA(string valorA)
        {
            this.valorA = int.Parse(valorA);
        }

        private void setValorB(string valorB)
        {
            this.valorB = int.Parse(valorB);
        }

        private void aplicarGradeDeEuclides()
        {

            for (int a = 1; a <= qtdInteracoes; a++)
            {
                setValores(Console.ReadLine());

                if (valorA - valorB < 0)
                {
                    buffer = valorA;
                    valorA = valorB;
                    valorB = buffer;
                }

                //ALGORITIMO PARA A GRADE DE EUCLIDES

                int restoDivisao = 0;

                if (valorA == valorB)
                {
                    resposta = valorA;
                }
                else
                {
                    while (true)
                    {
                        restoDivisao = valorA % valorB;

                        if (restoDivisao == 0)
                        {
                            resposta = valorB;
                            break;
                        }
                        else
                        {
                            valorA = valorB;
                            valorB = restoDivisao;
                        }

                    }
                }
                Console.WriteLine(resposta);
            }
            Console.ReadKey();
        }
    }
}

/*
 * URI Online Judge | 1161 https://www.urionlinejudge.com.br/judge/pt/problems/view/1161
 * Fatorial
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.MATEMATICA
{
    class _1161
    {
        private string entrada;
        private int numA, numB;
        private long resultA, resultB;

        public _1161()
        {
            calcular();
            Console.ReadKey();
        }

        private void setNumA(string entrada)
        {
            numA = int.Parse(entrada.Split(' ')[0]);
        }

        private void setNumB(string entrada)
        {
            numB = int.Parse(entrada.Split(' ')[1]);
        }

        private int protecaoZeroFatorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num;
        }

        private long calcularFatorial(int num)
        {
            if (num <= 1)
            {
                return 1;

            }
            else
            {
                return num * calcularFatorial(num - 1);
            }
        }

        private void calcular()
        {
            while (true)
            {
                entrada = Console.ReadLine();

                setNumA(entrada);
                setNumB(entrada);

                if (!String.IsNullOrEmpty(entrada))
                {
                    numA = protecaoZeroFatorial(int.Parse(entrada.Split(' ')[0]));
                    numB = protecaoZeroFatorial(int.Parse(entrada.Split(' ')[1]));

                    resultA = calcularFatorial(numA);
                    resultB = calcularFatorial(numB);

                    Console.WriteLine(resultA + resultB);

                }
                else
                {
                    break;
                }

            }
            
        }
    }
}

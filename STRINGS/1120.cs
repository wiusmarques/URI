/*
 * URI Online Judge | 1120 https://www.urionlinejudge.com.br/judge/pt/problems/view/1120
 * Conversão entre Bases
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.STRINGS
{
    class _1120
    {
        string entrada, digitoIncorreto, numContrato;

        public _1120()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            while (true)
            {
                entrada = Console.ReadLine();

                if (entrada != "0 0")
                {
                    digitoIncorreto = entrada.Split(' ')[0];
                    numContrato = entrada.Split(' ')[1];
                    VerificarErro(digitoIncorreto, numContrato);
                }
                else
                {
                    break;
                }

            }
        }

        private void VerificarErro(string digitoIncorreto, string numContrato)
        {
            string contratoComErro = numContrato.Replace(digitoIncorreto, "");

            contratoComErro = RemoverZeroEsquerda(contratoComErro);
            contratoComErro = TratarStringVazia(contratoComErro);
            Console.WriteLine(contratoComErro);

        }

        private string RemoverZeroEsquerda(string contratoComErro)
        {
            for (int i = 0; i < contratoComErro.Length; i++)
            {
                if (contratoComErro[i] == '0')
                {
                    if (i == contratoComErro.Length - 1)
                    {
                        return "0";
                    }
                    continue;
                }
                else
                {
                    contratoComErro = contratoComErro.Substring(i);
                    break;
                }
            }

            return contratoComErro;
        }

        private string TratarStringVazia(string contratoComErro)
        {
            if (string.IsNullOrEmpty(contratoComErro))
            {
                return "0";
            }
            else
            {
                return contratoComErro;
            }
        }
    }
}

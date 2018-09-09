/*
 * URI Online Judge | 1005 https://www.urionlinejudge.com.br/judge/pt/problems/view/1005
 * Média 1
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.INICIANTE
{
    class _1005
    {
        private double media;
        private string mediaFormatada;

        public _1005()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            double notaA = double.Parse(Console.ReadLine());
            double notaB = double.Parse(Console.ReadLine());

            CalcularMedia(notaA, notaB);
        }

        private void CalcularMedia(double notaA, double notaB)
        {
            media = Math.Round((notaA * 3.5 + notaB * 7.5) / 11, 5);
            mediaFormatada = string.Format("{0:n5}", media);

            Console.WriteLine("MEDIA = " + mediaFormatada);
        }
    }
}

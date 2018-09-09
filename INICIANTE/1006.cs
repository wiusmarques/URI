/*
 * URI Online Judge | 1006 https://www.urionlinejudge.com.br/judge/pt/problems/view/1006
 * Média 2
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.INICIANTE
{
    class _1006
    {
        private double notaA, notaB, notaC, media;
        private string mediaFormatada;
        public _1006()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            SetNotas();
            CalcularMedia();
            
        }

        private void SetNotas()
        {
            notaA = double.Parse(Console.ReadLine());
            notaB = double.Parse(Console.ReadLine());
            notaC = double.Parse(Console.ReadLine());
        }

        private void CalcularMedia()
        {
            media = Math.Round((notaA * 2.0 + notaB * 3.0 + notaC * 5.0) / 10, 1);
            mediaFormatada = string.Format("{0:N1}", media);
            Console.WriteLine("MEDIA = " + mediaFormatada);
        }

        
    }
}

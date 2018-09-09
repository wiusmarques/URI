/*
 * URI Online Judge | 1024 https://www.urionlinejudge.com.br/judge/pt/problems/view/1024
 * Criptografia
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */
using System.Text;
using System;

namespace URI.STRINGS
{
    class _1024
    {
        private int qtdIteracoes;

        public _1024(string qtdIteracoes)
        {
            setQtdIteracoes(qtdIteracoes);
            programa();
        }

        private void setQtdIteracoes(string qtdIteracoes)
        {
            this.qtdIteracoes = int.Parse(qtdIteracoes);
        }

        private void programa()
        {

            string entrada, txtCripto;

            for (int a = 0; a < qtdIteracoes; a++)
            {
                entrada = Console.ReadLine();
                txtCripto = primeiraPassada(entrada);
                txtCripto = segundaPassada(txtCripto);
                txtCripto = TerceiraPassada(txtCripto);
                Console.WriteLine(txtCripto);
            }

            Console.ReadKey();

        }

        private string primeiraPassada(string txt)
        {

            byte[] arrManupulacao = Encoding.ASCII.GetBytes(txt);

            for (int a = 0; a < txt.Length; a++)
            {
                if ((arrManupulacao[a] > 64 && arrManupulacao[a] < 91) || (arrManupulacao[a] > 96 && arrManupulacao[a] < 123))
                {
                    int novaPosicaoASCII = arrManupulacao[a] + 3;
                    byte newByte = byte.Parse(novaPosicaoASCII.ToString());
                    arrManupulacao[a] = newByte;
                }
            }

            return new string(Encoding.ASCII.GetChars(arrManupulacao));
        }

        private string segundaPassada(string txt)
        {
            char[] arrChar = txt.ToCharArray();
            String stringInvertida;

            Array.Reverse(arrChar);
            stringInvertida = new String(arrChar);

            return new string(arrChar);
        }

        private string TerceiraPassada(string txt)
        {
            int sizeParteA = txt.Length / 2;
            int sizeParteB = txt.Length - (txt.Length / 2);

            string parteA = txt.Substring(0, sizeParteA);
            string parteB = txt.Substring(sizeParteA, sizeParteB);

            parteB = aplicarUltimaPassada(parteB);

            return string.Format("{0}{1}", parteA, parteB);
        }

        private string aplicarUltimaPassada(string txt)
        {
            byte[] arrBytes = Encoding.ASCII.GetBytes(txt);
            for (int a = 0; a < arrBytes.Length; a++)
            {
                if (arrBytes[a] == 21)
                {
                    arrBytes[a] = 126;
                }
                else
                {
                    int novaPosicaoASCII = arrBytes[a] - 1;
                    byte newByte = byte.Parse(novaPosicaoASCII.ToString());
                    arrBytes[a] = newByte;

                }
            }

            return new string(Encoding.ASCII.GetChars(arrBytes));
        }
    }
}

/*
 * URI Online Judge | 1168 https://www.urionlinejudge.com.br/judge/pt/problems/view/1168
 * LEDS
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.STRINGS
{
    class _1168
    {
        int casosTeste = int.Parse(Console.ReadLine());
        int quantidadeLeds = 0;
        string numeroPainel;
        //StreamWriter sw = new StreamWriter("SAIDA.TXT");

        public _1168()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            while (casosTeste != 0)
            {
                numeroPainel = Console.ReadLine();

                for (int i = 0; i < numeroPainel.Length; i++)
                {
                    switch (numeroPainel[i])
                    {
                        case '1':
                            quantidadeLeds += 2;
                            break;
                        case '2':
                            quantidadeLeds += 5;
                            break;
                        case '3':
                            quantidadeLeds += 5;
                            break;
                        case '4':
                            quantidadeLeds += 4;
                            break;
                        case '5':
                            quantidadeLeds += 5;
                            break;
                        case '6':
                            quantidadeLeds += 6;
                            break;
                        case '7':
                            quantidadeLeds += 3;
                            break;
                        case '8':
                            quantidadeLeds += 7;
                            break;
                        case '9':
                            quantidadeLeds += 6;
                            break;
                        case '0':
                            quantidadeLeds += 6;
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine(quantidadeLeds + " leds");
                //sw.WriteLine(quantidadeLeds + " leds");

                quantidadeLeds = 0;
                casosTeste--;
            }

            //sw.Close();
        }
    }
}

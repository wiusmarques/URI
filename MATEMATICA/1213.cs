/*
 * URI Online Judge | 1213 https://www.urionlinejudge.com.br/judge/pt/problems/view/1213
 * ONES
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;

namespace URI.MATEMATICA
{
    class _1213
    {
        private string entradaLiteral;
        private int quantidadeCasas = 1;
        private String resto = "1";
        int entrada;

        public _1213()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            while (true)
            {
                //ARMAZENANDO O NÚMERO QUE SERÁ ANALIZADO
                entradaLiteral = Console.ReadLine();
                if (!string.IsNullOrEmpty(entradaLiteral))
                {

                    //BUSCAR PELO MMC QUE TENHA TODAS AS SUAS CASAS COMPOSTAS PELO DÍGITO 1
                    entrada = int.Parse(entradaLiteral);

                    while (true)
                    {
                        if (resto.Length < entradaLiteral.Length)
                        {
                            resto += '1';
                            quantidadeCasas++;
                        }
                        else
                        {
                            if (int.Parse(resto) % entrada != 0)
                            {
                                resto = (int.Parse(resto) % entrada).ToString() + "1";
                                quantidadeCasas++;
                            }
                            else
                            {
                                Console.WriteLine(quantidadeCasas);
                                resto = "1";
                                quantidadeCasas = 1;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    //EOF
                    break;
                }
            }
        }
    }
}

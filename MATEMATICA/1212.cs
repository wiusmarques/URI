/*
 * URI Online Judge | 1212 https://www.urionlinejudge.com.br/judge/pt/problems/view/1212
 * Aritmética Primária
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;
using System.Linq;

namespace URI.MATEMATICA
{
    class _1212
    {

        private string entrada;
        private string numA, numB, maior;
        private int quantidadeQuery = 0, query = 0;

        public _1212()
        {
            StartProcess();
        }

        private void StartProcess()
        {
            

            //StreamWriter sw = new StreamWriter("SAIDA.txt");
            while (true)
            {
                entrada = Console.ReadLine();

                if (entrada == "0 0")
                {
                    break;
                }

                numA = entrada.Split(' ')[0];
                numB = entrada.Split(' ')[1];

                numA = new string(numA.Reverse().ToArray());
                numB = new string(numB.Reverse().ToArray());

                maior = numA.Length >= numB.Length ? numA : numB;

                for (int a = 0; a < maior.Length; a++)
                {
                    int x = a < numA.Length ? int.Parse(numA[a].ToString()) : 0;
                    int y = a < numB.Length ? int.Parse(numB[a].ToString()) : 0;


                    if (x + y + query >= 10)
                    {
                        query = x + y + query >= 10 ? 1 : 0;
                        quantidadeQuery++;
                    }
                    else
                    {
                        query = x + y + query >= 10 ? 1 : 0;
                    }
                }

                switch (quantidadeQuery)
                {
                    case 0:
                        //sw.WriteLine("No carry operation.");
                        Console.WriteLine("No carry operation.");
                        break;
                    case 1:
                        //sw.WriteLine(quantidadeQuery + " carry operation.");
                        Console.WriteLine(quantidadeQuery + " carry operation.");
                        break;
                    default:
                        //sw.WriteLine(quantidadeQuery + " carry operations.");
                        Console.WriteLine(quantidadeQuery + " carry operations.");
                        break;
                }

                quantidadeQuery = 0;
                query = 0;
            }
            //sw.Close();
        }
    }
}

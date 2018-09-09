/*
 * URI Online Judge | 1193 https://www.urionlinejudge.com.br/judge/pt/problems/view/1193
 * Conversão entre Bases
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlool.com
 */

/* ------ ATENÇÃO! ------
 * 
* O código quando enviado para o URI apresenta o erro "Presentation error"
* Aparentemente o código faz exatamente o que o exercício pede, entretanto 
* é necessária uma análise sistemática antes de afirmarmos que o exercício 
* foi concluído com sucesso
*/

using System;

namespace URI.MATEMATICA
{
    class _1193
    {

        public _1193()
        {
            startProcess();
        }

        private void startProcess()
        {
            int quantidadeCasosTeste = int.Parse(Console.ReadLine());
            string entrada;
            string[] Valores = new string[quantidadeCasosTeste];
            string[] Bases = new string[quantidadeCasosTeste];



            for (int i = 0; i < quantidadeCasosTeste; i++)
            {
                entrada = Console.ReadLine();
                Valores[i] = entrada.Split(' ')[0];
                Bases[i] = entrada.Split(' ')[1];
            }

            for (int i = 0; i < quantidadeCasosTeste; i++)
            {
                int caso = i + 1;
                Console.WriteLine("Case " + caso + ":");
                EfetuarConversoes(Valores[i], Bases[i]);
                Console.Write("\n");
            }
        }

        void EfetuarConversoes(string num, string baseNumericaInformada)
        {
            switch
                (baseNumericaInformada)
            {
                case "bin":
                    BinToDec(num, baseNumericaInformada);
                    BinToHex(num, baseNumericaInformada);
                    break;

                case "dec":
                    DecToHex(num, baseNumericaInformada);
                    DecToBin(num, baseNumericaInformada);
                    break;
                case "hex":
                    HexToDec(num, baseNumericaInformada);
                    HexToBin(num, baseNumericaInformada);
                    break;

            }
        }

        private void BinToHex(string binNumber, string baseNumericaInformada)
        {

            Int64 intValue = Convert.ToInt64(binNumber, 2);
            string hexValue = intValue.ToString("X");
            Console.WriteLine(hexValue + " hex");
        }

        private void BinToDec(string binNumber, string baseNumericaInformada)
        {
            Int64 decValue = Convert.ToInt64(binNumber, 2);
            Console.WriteLine(decValue + " dec");
        }

        private void HexToDec(string hexNumber, string baseNumericaInformada)
        {
            Int64 decValue = Convert.ToInt64(hexNumber, 16);
            Console.WriteLine(decValue + " dec");
        }

        private void HexToBin(string hexNumber, string baseNumericaInformada)
        {
            Int64 intValue = Convert.ToInt64(hexNumber, 16);
            string binNuber = Convert.ToString(intValue, 2);
            Console.WriteLine(binNuber + " bin");
        }

        private void DecToHex(string decNumber, string baseNumericaInformada)
        {
            Int64 intValue = Convert.ToInt64(decNumber);
            string hexValue = Convert.ToString(intValue, 16);
            Console.WriteLine(hexValue + " hex");
        }

        private void DecToBin(string decNumber, string baseNumericaInformada)
        {
            Int64 intValue = Convert.ToInt64(decNumber);
            string binValue = Convert.ToString(intValue, 2);
            Console.WriteLine(binValue + " bin");
        }
    }

    
}
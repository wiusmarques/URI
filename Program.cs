using System;
using System.Collections;
using System.IO;
using URI.INICIANTE;
using URI.MATEMATICA;

namespace URI
{
    class Program
    {


        static void Main(string[] args)
        {
            string entrada, teclaDanificada, numeroContrato, stringOriginalContrato;
            long numeroOriginalContrato;

            while (true)
            {
                entrada = Console.ReadLine();

                if (entrada != "0 0")
                {
                    teclaDanificada = entrada.Split(' ')[0];
                    numeroContrato = entrada.Split(' ')[1];
                    stringOriginalContrato = numeroContrato.Replace(teclaDanificada, "");

                    stringOriginalContrato = stringOriginalContrato == "" ? "0" : stringOriginalContrato;

                    numeroOriginalContrato = long.Parse(stringOriginalContrato);

                    Console.WriteLine(numeroOriginalContrato);

                }
                else
                {
                    break;
                }
            }
        }
    }
}

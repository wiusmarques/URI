using System;
using System.IO;
using URI.INICIANTE;
using URI.STRINGS;
using URI.MATEMATICA;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int v, t;
            while (true)
            {
                entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    //EOF
                    break;
                }

                v = int.Parse(entrada.Split(' ')[0]);
                t = int.Parse(entrada.Split(' ')[1]);

                Console.WriteLine(v * t * 2);
            }
        }

    }
}
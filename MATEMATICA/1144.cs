/*
 * URI Online Judge | 1144 https://www.urionlinejudge.com.br/judge/pt/problems/view/1144
 * Acima da Média
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlook.com
 */

using System;
using System.Linq;

namespace URI.MATEMATICA
{
    class _1144
    {
        private string entrada;
        private int numCasosTeste;
        private double quantidadeAlunos, quantidadeAlunosAcimaMedia = 0;
        private double mediaTurma, percentualAlunosAcimaMedia;

        public _1144()
        {
            startProcess();
        }

        private void startProcess()
        {

            //StreamWriter sw = new StreamWriter("saida.txt");
            numCasosTeste = int.Parse(Console.ReadLine());

            for (int a = 0; a < numCasosTeste; a++)
            {
                //ARMAZENAMOS UMA STRING INICIAL
                entrada = Console.ReadLine();

                //RESERVAMOS A QUANTIDADE TOTAL DE ALUNOS
                quantidadeAlunos = int.Parse(entrada.Split(' ')[0]);

                //CONVERTEMOS UM ARRAY DE STRINGS EM UMA LISTA GENERICA DE INTEIROS PARA FACILITAR A MANIPULAÇÃO
                var arrayNotasInt = entrada.Split(' ').Select(double.Parse).ToList();

                //RETIRAMOS A PRIMEIRA POSIÇÃO E DEIXAMOS APENAS UM ARRAY DE NOTAS
                arrayNotasInt.RemoveAt(0);

                //CALCULAMOS O VALOR DA MEDIA DA TURMA
                mediaTurma = Math.Round(arrayNotasInt.Sum() / quantidadeAlunos, 3);

                //VERIFICAMOS QUAL DAS NOTAS É MAIOR DO QUE A MÉDIA DA TURMA
                foreach (int elemeto in arrayNotasInt)
                {
                    if (elemeto > mediaTurma)
                    {
                        quantidadeAlunosAcimaMedia++;
                    }
                }
                //CALCULANDO PERCENTUA DE ALUOS ACIMA DA MÉDIA
                percentualAlunosAcimaMedia = Math.Round(quantidadeAlunosAcimaMedia * 100 / quantidadeAlunos, 3);

                //EXIBINDO O PERCENTUAL NO FORMATO EXIGIDO PELO EXERCÍCIO 
                Console.WriteLine(percentualAlunosAcimaMedia.ToString("N3") + "%");

                //SALVANDO EM UM ARQUIVO TEXTO PARA VALIDAÇÃO
                //sw.WriteLine(percentualAlunosAcimaMedia.ToString("N3") + "%");

                //ZERANDO VARIAVEIS
                quantidadeAlunosAcimaMedia = 0;
            }
            //sw.Close();
        }
    }
}

/*
 * URI Online Judge | 1002 https://www.urionlinejudge.com.br/judge/pt/problems/view/1002
 * Área do Círculo
 * Autor: Wiusmarques Moreira dos Reis
 * Contato: wiusmarques.dev@outlool.com
 */

namespace URI.INICIANTE
{
    class _1002
    {
        private const double PI = 3.14159;
        private double raio;
        private double areaDoCirculo;
        private string textoFormatado;

        public _1002(string raio)
        {
            setRaio(raio);
            calcularAreaCirculo();
        }

        private void setRaio(string raio)
        {
            this.raio = double.Parse(raio);
        }

        private void calcularAreaCirculo()
        {
            areaDoCirculo = System.Math.Round(PI * System.Math.Pow(raio, 2), 4);
            formatarTextoFinal();
        }

        private void formatarTextoFinal()
        {
            /*
             * O COMPILADOR DO EXERCICIO CONSIDERA A ',' COMO SEPARADOR DAS CASAS INTEIRAS E O '.' COMO SEPARADOR DAS CASAS DECIMAIS
             * CASO TENHA QUE COMPILAR EM UM LOCAL ONDE O '.' É O DELIMITADOR DAS CASAS INTEIRAS E A ',' É O DELIMITADOR DAS CASAS DECIMAIS
             * TROQUE O Replace(".","") PARA Replace(",","").
             */
            textoFormatado = string.Format("A={0:n4}", this.areaDoCirculo).Replace(".","");
        }

        public string resposta()
        {
            return this.textoFormatado;
        }


    }
}

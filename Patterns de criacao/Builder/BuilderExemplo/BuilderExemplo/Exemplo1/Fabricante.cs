using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExemplo.Exemplo1.Celular;

namespace BuilderExemplo.Exemplo1
{

    // O diretor trabalha com qualquer instância builder que
    // o código cliente passar a ele. Dessa forma, o código
    // cliente pode alterar o tipo final do produto recém
    // montado. O diretor pode construir diversas variações
    // do produto usando as mesmas etapas de construção.
    public class Fabricante
    {
        public void ConstruirCelularCompleto(ICelularBuilder celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildTela();
            celularBuilder.BuildSistema();
        }

        public void ConstruirCelularSemBateria(ICelularBuilder celularBuilder)
        {
            celularBuilder.BuildTela();
            celularBuilder.BuildSistema();
        }
    }
}

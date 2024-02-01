using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Factory_Method.Personagens.Relacionamentos
{
    public class Golpes
    {
        public string Tipo { get; set; }
        public int RetiraDeVida {  get; set; }

        public Golpes(string tipo, int retiraDeVida)
        {
            Tipo = tipo;
            RetiraDeVida = retiraDeVida;
        }
    }
}

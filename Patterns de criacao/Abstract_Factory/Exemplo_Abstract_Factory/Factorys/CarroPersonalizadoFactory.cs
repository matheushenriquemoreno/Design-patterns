using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_Abstract_Factory.Entities.Carro.Roda;
using Exemplo_Abstract_Factory.Entities.Carro.Som;

namespace Exemplo_Abstract_Factory.Factorys
{
    public class CarroPersonalizadoFactory : CarroFactory
    {
        public override IRoda MontarRoda()
        {
            return new RodaAro20();
        }

        public override ISom MontarSom()
        {
            return new SomAutomotivo();
        }
    }
}

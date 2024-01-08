using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_Abstract_Factory.Entities.Carro;
using Exemplo_Abstract_Factory.Factorys;

namespace Exemplo_Abstract_Factory
{
    public class ExecutaAbstractFactory
    {

        public static Carro MontarCarro(string tipo)
        {
            CarroFactory carroFactory = null;

            switch (tipo)
            {
                case "luxo":
                    carroFactory = new CarroLuxoFactory();
                    break;
                case "popular":
                    carroFactory = new CarroPopularFactory();
                    break;
                case "personalizado":
                    carroFactory = new CarroPersonalizadoFactory();
                    break;
                default:
                    throw new InvalidOperationException("Carro ainda não construido!");
            }

            var carro = new Carro(carroFactory.MontarRoda(), carroFactory.MontarSom());
            return carro;
        }
    }
}

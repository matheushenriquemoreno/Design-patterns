
using Exemplo_Abstract_Factory.Entities.Carro.Roda;
using Exemplo_Abstract_Factory.Entities.Carro.Som;

namespace Exemplo_Abstract_Factory.Entities.Carro
{
    public class Carro
    {
        public IRoda Roda { get; set; }
        public ISom Som { get; set; }

        public Carro(IRoda roda, ISom som)
        {
            Roda = roda;
            Som = som;
        }
    }
}

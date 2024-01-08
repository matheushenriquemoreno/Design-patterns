using Exemplo_Abstract_Factory.Entities.Carro.Roda;
using Exemplo_Abstract_Factory.Entities.Carro.Som;

namespace Exemplo_Abstract_Factory.Factorys;

public abstract class CarroFactory
{
    public abstract IRoda MontarRoda();
    public abstract ISom MontarSom();
}

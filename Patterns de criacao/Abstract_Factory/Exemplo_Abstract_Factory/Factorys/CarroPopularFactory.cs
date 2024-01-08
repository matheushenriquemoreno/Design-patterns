using Exemplo_Abstract_Factory.Entities.Carro.Roda;
using Exemplo_Abstract_Factory.Entities.Carro.Som;

namespace Exemplo_Abstract_Factory.Factorys;

public class CarroPopularFactory : CarroFactory
{
    public override IRoda MontarRoda()
    {
        return new RodaSimples();
    }

    public override ISom MontarSom()
    {
        return new SomNormal();
    }
}

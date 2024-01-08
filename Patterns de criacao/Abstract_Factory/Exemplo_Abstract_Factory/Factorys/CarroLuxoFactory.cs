using Exemplo_Abstract_Factory.Entities.Carro.Roda;
using Exemplo_Abstract_Factory.Entities.Carro.Som;

namespace Exemplo_Abstract_Factory.Factorys;

public class CarroLuxoFactory : CarroFactory
{
    public override IRoda MontarRoda()
    {
        return new RodaLigaLeve();
    }

    public override ISom MontarSom()
    {
        return new SomBluetooh();
    }
}

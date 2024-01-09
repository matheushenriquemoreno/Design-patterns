using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPrototype.Entities
{
    public interface IFuncionario
    {
        string Nome { get; }
        int Idade { get; }

        IFuncionario Clone();
    }
}

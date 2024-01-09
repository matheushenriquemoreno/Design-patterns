using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPrototype.Entities
{
    public class FuncionarioTemporario : IFuncionario
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public IFuncionario Clone()
        {
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}

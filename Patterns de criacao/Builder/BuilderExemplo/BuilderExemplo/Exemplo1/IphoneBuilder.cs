using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExemplo.Exemplo1.Celular;
using BuilderExemplo.Exemplo1.Celular.Bateria;
using BuilderExemplo.Exemplo1.Celular.Sistema;
using BuilderExemplo.Exemplo1.Celular.Tela;

namespace BuilderExemplo.Exemplo1
{
    internal class IphoneBuilder : ICelularBuilder
    {
        public Celular.Celular Celular { get; private set; } = new Celular.Celular("Iphone 12");

        public void BuildBateria()
        {
            this.Celular.Bateria = new BateriaMedia();
        }

        public void BuildSistema()
        {
            this.Celular.Tela = new DisplayAmoled();
        }

        public void BuildTela()
        {
            this.Celular.Sistema = new AppleIOS();
        }
    }
}

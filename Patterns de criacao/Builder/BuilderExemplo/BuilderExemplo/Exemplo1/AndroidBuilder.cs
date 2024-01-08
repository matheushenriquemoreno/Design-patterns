using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExemplo.Exemplo1.Celular;
using BuilderExemplo.Exemplo1.Celular.Bateria;
using BuilderExemplo.Exemplo1.Celular.Sistema;
using BuilderExemplo.Exemplo1.Celular.Tela;

namespace BuilderExemplo.Exemplo1;

public class AndroidBuilder : ICelularBuilder
{
    public Celular.Celular Celular { get; private set; } = new Celular.Celular("Sansung s23");

    public void BuildBateria()
    {
        this.Celular.Bateria = new BateriaMedia();
    }

    public void BuildSistema()
    {
        this.Celular.Sistema = new Android();   
    }

    public void BuildTela()
    {
        this.Celular.Tela = new DisplayAmoled();
    }
}

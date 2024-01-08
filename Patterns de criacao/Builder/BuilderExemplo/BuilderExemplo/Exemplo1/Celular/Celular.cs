using BuilderExemplo.Exemplo1.Celular;

namespace BuilderExemplo.Exemplo1.Celular;

public class Celular
{
    public string Modelo { get; private set; }
    public ITela Tela { get; set; }
    public IBateria Bateria { get; set; }
    public ISistema Sistema { get; set; }

    public Celular(string modelo)
    {
        Modelo = modelo;
    }
}

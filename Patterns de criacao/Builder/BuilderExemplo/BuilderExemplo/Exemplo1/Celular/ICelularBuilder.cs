namespace BuilderExemplo.Exemplo1.Celular;

public interface ICelularBuilder
{
    void BuildTela();
    void BuildBateria();
    void BuildSistema();
   
    Celular Celular { get; }
}

namespace ExemploPrototype.Entities;

public class FuncionarioPermanente : IFuncionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public IFuncionario Clone()
    {
       return this.MemberwiseClone() as IFuncionario; // faz uma copia desse objeto e faz um casting para IFuncionario
    }


    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}

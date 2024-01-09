/*
 Objetivo: O objetivo do padrão e passar a resposabilidade da classe ou entidade, que faça o clone dela propria.
Poís podem conter regras que existam somente dentro dela.


 Site: 
 https://refactoring.guru/pt-br/design-patterns/prototype
 */



using ExemploPrototype.Entities;

var funcionarioPermamente = new FuncionarioPermanente()
{
    Idade = 21,
    Nome = "Gabriel"
};


FuncionarioPermanente cloneFuncionario = funcionarioPermamente.Clone() as FuncionarioPermanente;

cloneFuncionario.Nome = "José";

Console.WriteLine(funcionarioPermamente);
Console.WriteLine(cloneFuncionario);

Console.ReadLine();
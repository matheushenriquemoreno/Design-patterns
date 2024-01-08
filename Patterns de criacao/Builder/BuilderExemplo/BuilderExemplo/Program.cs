/*
 
Objetivo:
Separar a construção de um objeto complexo de sua represetação para que o mesmo processo 
de contrução possa criar diferentes representações.

 Site:
https://refactoring.guru/pt-br/design-patterns/builder
 */

using BuilderExemplo.Exemplo1;
using BuilderExemplo.Exemplo1.Celular;

Console.WriteLine("----------------------------");
CriarCelular(new AndroidBuilder());
CriarCelular(new IphoneBuilder());
Console.WriteLine("----------------------------");

void CriarCelular(ICelularBuilder createBuilder)
{
    // Crio a classe que vai gerenciar a criação da entidade
    var director = new Fabricante();

    // chamado o metodo que adequa a minha necessidade
    director.ConstruirCelularCompleto(createBuilder);
    
    // obtenho a intancia da entidade com base na clase de criação de objeto.
    var celular = createBuilder.Celular;

    Console.WriteLine(celular.Modelo);
}
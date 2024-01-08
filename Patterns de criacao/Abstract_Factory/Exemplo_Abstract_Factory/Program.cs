/* 
Objetivo:
O Abstract Factory é um padrão de projeto criacional que permite que você
produza famílias de objetos relacionados sem ter que especificar suas classes concretas.

Site:
https://refactoring.guru/pt-br/design-patterns/abstract-factory
 */

using Exemplo_Abstract_Factory;

var carroLuxo = ExecutaAbstractFactory.MontarCarro("luxo");
var carroPopular = ExecutaAbstractFactory.MontarCarro("popular");
var carroPersonalizado = ExecutaAbstractFactory.MontarCarro("personalizado");

Console.ReadLine();


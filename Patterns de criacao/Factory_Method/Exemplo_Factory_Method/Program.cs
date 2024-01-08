using Exemplo_Factory_Method.Factory;
using Exemplo_Factory_Method.Personagens;

var fabrica = new FactoryMethod();

Console.WriteLine("Liu Kang | SubZero | Scorpion ");
Console.WriteLine();

Console.WriteLine("Escoolha seu personagem");
string escolha = Console.ReadLine();

IPersonagem personagem = fabrica.Escolher_Personagem(escolha);

Console.WriteLine("Você vai jogar com o personagem:");
personagem.Escolhido();


var teste = personagem.GetType();
Console.WriteLine(teste);


Console.ReadKey();



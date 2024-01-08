

using ExemploSingleton;

var jogador1 = Singleton.GetInstancia;
jogador1.Mensagem("Jogador 1: a bola está comigo");

var jogador2 = Singleton.GetInstancia;
jogador2.Mensagem("jogador 2: recebi a bola");


Console.ReadKey();
/*
 Objetivo:

Converter uma inteface de ma classe em outra interface que os clientes esperam. 
O adptador permite que as classes tabalhem juntas, o que não poderia ocorrer deviado 
a interfaces incompatíveis.

-- uso

padrão esse que poder utilizado para bibliotecas, 
visando ter uma interface padrão e adapter para os ambientes ou frameworks que utilizam.
exemplo uma interface de usuario, onde pode ter 3 possiveis sistema operacional.(Linux, windowns e Mac)
fazendo assim uma inteface que padrão e utilizando os metodos especificos de cada sistema operacional.

 */


using PattnerAdapter.Adapter;
using PattnerAdapter.Entities;

var tanqueInimigo = new TanqueInimigo();

var roborD2 = new RoboInimigo();

IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(roborD2);


Console.WriteLine("-------- Robor ------------");
roborD2.EsmagarComMaos();
roborD2.AnderFrente();
roborD2.ReagirContraHumano("Rodrigo");

Console.WriteLine("-------- Tanque ------------");
tanqueInimigo.ArmaFogo();
tanqueInimigo.Movimenta();
tanqueInimigo.Pilotar("Joaquim");

Console.WriteLine("-------- Adapter Robor ------------");
robo_adapter.ArmaFogo();
robo_adapter.Movimenta();
robo_adapter.Pilotar("Maria");
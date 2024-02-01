using System;
using Exemplo_Factory_Method.Personagens.Relacionamentos;

namespace Exemplo_Factory_Method.Personagens
{
    public class Scorpion : IPersonagem
    {
        public List<Golpes> Golpes { get; set; } = new List<Golpes>();

        public int Vida { get; set; } = 100;

        public Scorpion()
        {
            Golpes.Add(new Golpes("Tiro de Fogo", 10));
        }

        public void Escolhido()
        {
   
            Console.WriteLine("Scorpion");
        }
    }
}

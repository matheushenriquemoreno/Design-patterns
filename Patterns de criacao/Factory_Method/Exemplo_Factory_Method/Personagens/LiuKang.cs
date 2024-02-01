using System;
using Exemplo_Factory_Method.Personagens.Relacionamentos;

namespace Exemplo_Factory_Method.Personagens
{
    public class LiuKang : IPersonagem
    {
        public List<Golpes> Golpes { get; set; } = new List<Golpes>();

        public int Vida { get; set; } = 100;

        public LiuKang()
        {
            Golpes.Add(new Golpes("Porrada", 10));
        }

        public void Escolhido()
        {
            Console.WriteLine("Personagem: Liu Kang Força: 30");
        }
    }
}

using System;
using Exemplo_Factory_Method.Personagens.Relacionamentos;


namespace Exemplo_Factory_Method.Personagens
{
    public class SubZeros : IPersonagem
    {
        public List<Golpes> Golpes { get; set; } = new List<Golpes>();

        public int Vida { get; set; } = 100;

        public SubZeros()
        {
            Golpes.Add(new Golpes("Tiro de Gelo", 10));
        }

        public void Escolhido()
        {
            Console.WriteLine("SubZeros");
        }
    }
}

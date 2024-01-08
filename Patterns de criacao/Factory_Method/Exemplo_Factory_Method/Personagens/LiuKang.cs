using System;

namespace Exemplo_Factory_Method.Personagens
{
    public class LiuKang : IPersonagem
    {
        public int MyProperty { get; set; }

        public LiuKang()
        {

        }

        public void Escolhido()
        {
            Console.WriteLine("Personagem: Liu Kang Força: 30");
        }
    }
}

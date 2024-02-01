using System;
using Exemplo_Factory_Method.Personagens.Relacionamentos;

namespace Exemplo_Factory_Method.Personagens
{
    public interface IPersonagem
    {
        List<Golpes> Golpes { get; }
        int Vida { get; }
        void Escolhido();
    }
}

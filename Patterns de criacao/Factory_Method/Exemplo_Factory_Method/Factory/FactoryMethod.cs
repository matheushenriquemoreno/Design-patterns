using System;
using Exemplo_Factory_Method.Personagens;

namespace Exemplo_Factory_Method.Factory
{
    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(string persoangem)
        {
            switch(persoangem.ToLower())
            {
                case "liu kang": return Activator.CreateInstance(type: typeof(LiuKang)) as IPersonagem;
                case "subzero": return new SubZeros();
                case "scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}

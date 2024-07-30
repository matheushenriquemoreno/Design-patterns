namespace PattnerAdapter.Entities
{
    /// <summary>
    ///  é o nosso Adappte - ele e o objeto que será adaptado.
    /// </summary>
    public class RoboInimigo
    {
        Random Gerador = new Random();

        public void EsmagarComMaos()
        {
            int dano = Gerador.Next(10) + 1;
            Console.WriteLine($"Ataque com as maos causou {dano} de dano");
        }

        public void AnderFrente()
        {
            int movimentacao = Gerador.Next(10) + 1;
            Console.WriteLine($"Robor andou: {movimentacao} passos");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine($"o Robor vai contra: {piloto}");
        }

    }
}

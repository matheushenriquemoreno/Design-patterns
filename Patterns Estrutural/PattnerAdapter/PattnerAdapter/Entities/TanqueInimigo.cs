namespace PattnerAdapter.Entities;

public class TanqueInimigo : IAtaqueInimigo
{
    Random Gerador = new Random();

    public void ArmaFogo()
    {
        int dano = Gerador.Next(10) + 1;
        Console.WriteLine($"Dano causado via Tanque: {dano}");
    }

    public void Movimenta()
    {
        int movimento = Gerador.Next(10) + 1;
        Console.WriteLine($"Tanque andou: {movimento} passos");
    }

    public void Pilotar(string piloto)
    {
        Console.WriteLine($"Piloto do Tanque: {piloto}");
    }
}

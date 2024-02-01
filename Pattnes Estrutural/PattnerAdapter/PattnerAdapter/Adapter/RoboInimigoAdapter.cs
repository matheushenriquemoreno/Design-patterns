using PattnerAdapter.Entities;

namespace PattnerAdapter.Adapter;

/// <summary>
/// é o nosso adapter - o adaptador do objeto robo com o Tanque. 
/// </summary>
public class RoboInimigoAdapter : IAtaqueInimigo
{
    private readonly RoboInimigo robo;

    public RoboInimigoAdapter(RoboInimigo novo_robo)
    {
        this.robo = novo_robo;
    }

    public void ArmaFogo()
    {
        this.robo.EsmagarComMaos();
    }

    public void Movimenta()
    {
        this.robo.AnderFrente();
    }

    public void Pilotar(string piloto)
    {
        this.robo.ReagirContraHumano(piloto);
    }
}

namespace src.Models;

public class Contrato
{
    public Contrato()
    {
        this.DataCriacao = DateTime.Now;
        this.Valor = 0;
        this.tokenId = "000000";
    }
    public DateTime DataCriacao { get; set; }
    public string tokenId { get; set; }
    public double Valor { get; set; }

}
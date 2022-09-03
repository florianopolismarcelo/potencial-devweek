using System.Collections.Generic;
namespace src.Models;

public class Pessoa
{
    public Pessoa()
    {
        this.Nome = "template";
        this.Idade = 0;
        this.Contratos = new List<Contrato>();
    }
    public Pessoa(string Nome, int Idade, string Cpf)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Cpf = Cpf;
    }
    //nome, idade, cpf, ativa
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }
    public List<Contrato> Contratos;
}
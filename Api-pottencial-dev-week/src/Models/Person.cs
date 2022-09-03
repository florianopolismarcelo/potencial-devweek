namespace src.Models;

public class Person
{
    public Person()
    {
        this.nome = "template";
        this.idade = 0;
    }

    public Person (string nome, int idade, string cpf){
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;

    }
    //nome, idade, cpf, ativa
    public string nome { get; set; }
    public int idade { get; set; }
    public string? cpf { get; set; }
    public bool ativado { get; set; }
}
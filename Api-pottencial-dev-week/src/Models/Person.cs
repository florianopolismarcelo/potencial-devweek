namespace src.Models;

public class Person
{
    public Person()
    {
        this.nome = "template";
        this.idade = 0;
    }
    //nome, idade, cpf, ativa
    public string nome { get; set; }
    public int idade { get; set; }
    public int cpf { get; set; }
    public bool ativado { get; set; }
}
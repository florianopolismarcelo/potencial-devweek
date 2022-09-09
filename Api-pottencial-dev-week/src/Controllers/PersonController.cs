using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{

    private DatabaseContext _repository { get; set; }
    
    [HttpGet]
    public Pessoa Get()
    {
        Pessoa pessoa = new Pessoa("marcelo", 45, "12345678");
        Contrato novocontrato = new Contrato("abc123", 50.46);
        pessoa.Contratos.Add(novocontrato);

        return pessoa;
    }
    [HttpPost]
    public Pessoa Post([FromBody] Pessoa pessoa)
    {
        return pessoa;
    }
    [HttpPut("{id}")]
    public string Updata([FromRoute] int id, [FromBody] Pessoa pessoa)
    {
        Console.WriteLine(id);
        Console.WriteLine(pessoa);
        return "Dados do id" + id + "atualizados";
    }
    [HttpDelete("{id}")]
    public string Delete([FromRoute] int id)
    {
        return "deletando pessoa de Id " + id;
    }
}
using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{
    [HttpGet]
    public Pessoa Get(){
        Pessoa pessoa = new Pessoa("marcelo", 45, "12345678");
        Contrato novocontrato = new Contrato("abc123", 50.46);
        pessoa.Contratos.Add(novocontrato);
        return pessoa;
    }
}
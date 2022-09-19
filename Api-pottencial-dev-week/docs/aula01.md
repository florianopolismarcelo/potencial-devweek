# Requesições HTTP

# Verbos HTTP
- Get - Selecionar/Buscar Dados
- Post - Enviar dados
- Put - Atualizar dados
- Patch - Atulizar parcialmente dados
- Delete - Deletar dados




# Verificar a implementação abaixo com o código existente e verificar o que está dando erro, após  resolver o erro colocar o código no PersonController.cs 

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

using src.Models;
using src.Persistence;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    private DatabaseContext _context { get; set; }

    public PersonController(DatabaseContext context)
    {
        this._context = context;
    }

    [HttpGet]
    public ActionResult<List<Pessoa>> Get()
    {
        //Ok - 200, NotContent 204
        // Pessoa pessoa = new Pessoa("marcelo", 45, "12345678");
        // Contrato novocontrato = new Contrato("abc123", 50.46);
        //pessoa.Contratos.Add(novocontrato);
        

        //return _context.Pessoas.Include(p => p.Contratos).ToList();
        //return pessoa;
        var result = _context.Pessoas.Include( p => p.Contratos).ToList();
        if (!result.Any()) return NoContent();
        return Ok(result);
    }
    [HttpPost]
    public ActionResult <Pessoa> Post([FromBody] Pessoa pessoa){
    try
    {
        _context.Pessoas.Add(pessoa);
        _context.SaveChanges();   
    }
    catch (System.Exception)
    {
        
        return BadRequest();
    {
        
        return Created ("Criado", pessoa);
    }
    // public Pessoa Post([FromBody] Pessoa pessoa)
    // {
    //     _context.Pessoas.Add(pessoa);
    //     _context.SaveChanges();

    //     return pessoa;
    // }
    
    [HttpPut("{id}")]
    //public ActionResult<Object> Delete([FromRoute] int id){
    public ActionResult<Object> Update(
        [FromRoute]int id, 
        [FromBody]Pessoa pessoa
        )
    {
        var result = _context.Pessoas.SingleOrDefault(e => e.Id == id);
        
        if (result is null){
            return NotFound(new {
                msg = "Registro não encontrado",
                status = HttpStatusCode.NotFound
            });
        }
        try
        {
         _context.Pessoas.Update(pessoa);
         _context.SaveChanges();
        }
        catch (System.Exception)
        {
            return BadRequest(new {
            msg = "Houve erro ao enviar solicitação de atualização do" 
            + id + "atualizados",
            status = HttpStatusCode.OK
          }); 
        }
        return Ok(new {
           //return "Dados do id" + id + "atualizados";
            msg = $"Dados do id {id} atualizados",
            status = HttpStatusCode.OK
        });
    }
    // public string Update([FromRoute] int id, [FromBody] Pessoa pessoa)
    // {
    //     _context.Pessoas.Update(pessoa);
    //     _context.SaveChanges();
    //     return "Dados do id" + id + "atualizados";

        //Console.WriteLine(id);
       // Console.WriteLine(pessoa);
    
    [HttpDelete("{id}")]

    public ActionResult<Object> Delete([FromRoute] int id){
        var result = _context.Pessoas.SingleOrDefault(e => e.Id == id);

        if (result is null){
         return BadRequest(new {
            msg = "Conteúdo inixistente, solicitação inválida",
            //status = 400
            status = HttpStatusCode.BadRequest
         });
    }
    // public string Delete([FromRoute] int id){
    //         var result = _context.Pessoas.SingleOrDefault (e => e.Id == id);

             _context.Pessoas.Remove(result);
             _context.SaveChanges();
        
        return Ok(new {
            msg = "deletando pessoa de Id " + id,
            //status = 200
            status = HttpStatusCode.OK
        });
    }
    }
    }
}
    // public ActionResult Delete([FromRoute] int id){
    //     return NotFound();
    // }
    


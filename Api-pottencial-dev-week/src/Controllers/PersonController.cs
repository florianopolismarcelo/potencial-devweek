using Microsoft.AspNetCore.Mvc;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController{

    public string Hello(){
        return "ola mundo";
    }
    
}
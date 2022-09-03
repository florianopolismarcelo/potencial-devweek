using Microsoft.AspNetCore.Mvc;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController  : ControllerBase
{
    [HttpGet]
    public string Hello()
    {
        return "ola Mar";
    }

}
using LanchesTop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesTop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : Controller
    {
        [HttpPost]
        public ActionResult Teste([FromBody] TesteViewModel teste) 
        {
            return StatusCode(200, new { nomeEnviado =  teste.Nome});
        }
    }
}

using Interview.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalizsController : ControllerBase
    {
        private IAnalizService _analizService;

        public AnalizsController(IAnalizService analizService)
        {
            _analizService = analizService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _analizService.SehirBazliAnalizYap();
            return Ok(list);
        }
    }
}

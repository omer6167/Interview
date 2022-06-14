using Interview.Business;
using Interview.Business.Abstract;
using Interview.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SepetsController : ControllerBase
{

    private ISepetService _sepetService;

    public SepetsController(ISepetService sepetService)
    {
        _sepetService = sepetService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {

        var values = _sepetService.GetAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult Add(Sepet musteri)
    {
        _sepetService.Add(musteri);
        return Ok();
    }
}
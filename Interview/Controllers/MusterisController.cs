using Interview.Business;
using Interview.Business.Abstract;
using Interview.DataAccess;
using Interview.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Interview.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MusterisController : ControllerBase
{
    private IMusteriService _musteriService;

    public MusterisController(IMusteriService musteriService)
    {
        _musteriService = musteriService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
            
        var values = _musteriService.GetAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult Add(Musteri musteri)
    {
        _musteriService.Add(musteri);
        return Ok();
    }



   
}
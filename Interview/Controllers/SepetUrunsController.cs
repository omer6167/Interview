using Interview.Business;
using Interview.Business.Abstract;
using Interview.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SepetUrunsController : ControllerBase
{
    private ISepetUrunService _sepetUrunService;

    public SepetUrunsController(ISepetUrunService sepetUrunService)
    {
        _sepetUrunService = sepetUrunService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {

        var values = _sepetUrunService.GetAll();
        return Ok(values);
    }

    [HttpGet("GetToplamTutar")]
    public IActionResult GetToplamTutar()
    {

        var values = _sepetUrunService.GetToplamSatis();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult Add(SepetUrun sepetUrun)
    {
        _sepetUrunService.Add(sepetUrun);
        return Ok();
    }

}
using Interview.Business.Abstract;

using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class TestVerisisController : ControllerBase
    {
        ITestVeriService _testVeriService;

        public TestVerisisController(ITestVeriService testVeriService)
        {
            _testVeriService = testVeriService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] int musteriAdet, [FromBody] int sepetAdet)
        {
            _testVeriService.TestVerisiOlustur(musteriAdet,sepetAdet);

            return Ok();
        }

    }
}

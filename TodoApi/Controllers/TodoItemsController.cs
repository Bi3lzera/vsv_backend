using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
          [ApiController]
          [Route("api/[controller]")]
          public class TodoItemsController : ControllerBase
          {
                    [HttpGet]
                    public IActionResult Get()
                    {
                              Primary p = new Primary();
                              string response = "OK"; //p.hellow;
                              return Ok(response);
                    }
          }
}
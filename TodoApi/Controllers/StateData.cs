using Microsoft.AspNetCore.Mvc;
using vsv_back.src.sql;

namespace vsv_api.Controllers
{
          [ApiController]
          [Route("api/[controller]")]
          public class StateData : ControllerBase
          {
                    [HttpGet]
                    public IActionResult Get(string state)
                    {
                              publicDatas p = new publicDatas();
                              string reponse = p.state(state);
                              return Ok(reponse);
                    }
          }
}
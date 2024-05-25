using Microsoft.AspNetCore.Mvc;
using vsv_back.src.sql;

namespace vsv_api.Controllers
{
          [ApiController]
          [Route("api/[controller]")]
          public class CityData : ControllerBase
          {
                    [HttpGet]
                    public IActionResult Get(string city)
                    {
                              publicDatas p = new publicDatas();
                              string reponse = p.city(city);
                              return Ok(reponse);
                    }
          }
}
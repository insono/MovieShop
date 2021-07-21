using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewController : ControllerBase
    {
        private readonly ICrewService _crewService;

        public CrewController(ICrewService crewService)
        {
            _crewService = crewService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCrews()
        {
            var crews = await _crewService.GetAllCrews();

            if (crews.Any())
            {
                return Ok(crews);
            }

            return NotFound("no crews found");
        }
    }
}

using ExceptionDealer.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ExceptionDealer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantInfoController : ControllerBase
    {
        private readonly IPlantMapService _mapService;

        public PlantInfoController(IPlantMapService mapService)
        {
            _mapService = mapService;
        }

        [HttpPost("{plantId?}/plantmap")]
        public IActionResult RetrievePlantMap(int plantId, PlantMapRequest plantMapReq)
        {
            string link = _mapService.GetMap(plantId, plantMapReq.Format, plantMapReq.Resolution);

            return Ok(@"{ ""Link"" : """ + link + @""" }");
        }
    }
}
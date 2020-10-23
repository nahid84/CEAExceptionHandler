using Services.Models;

namespace ExceptionDealer.Models
{
    public class PlantMapRequest
    {
        public PlantMapResolution Resolution { get; set; }
        public PlantMapFormat Format { get; set; }
    }
}

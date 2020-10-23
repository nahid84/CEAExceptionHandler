using Services.Models;

namespace Services
{
    public interface IPlantMapService
    {
        string GetMap(int plantId, PlantMapFormat format, PlantMapResolution resoultion);
    }
}

using CEASystemExceptions;
using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public class PlantMapService : IPlantMapService
    {
        public string GetMap(int plantId, PlantMapFormat format, PlantMapResolution resoultion)
        {
            if(PlantMapRegister.MapFormats.TryGetValue(plantId, out List<PlantMapFormat> mapFormat))
            {
                if (mapFormat == null || !mapFormat.Contains(format))
                    throw new InvalidFormatException($"Map format not registered as { format } for plant id { plantId}")
                    { UserMessage = $"Map format { format.ToString().ToLower() } not registered" };
            }
            else
            {
                throw new PlantNotFoundException($"Map format not found for plant id { plantId }") { UserMessage = "Plant not found" };
            }

            if (PlantMapRegister.MapResolutions.TryGetValue(plantId, out List<PlantMapResolution> mapResolution))
            {
                if (mapResolution == null || !mapResolution.Contains(resoultion))
                    throw new InvalidFormatException($"Map resolution not registered as { resoultion } for plant id { plantId}")
                    { UserMessage = $"Map resolution { resoultion.ToString().ToLower() } not registered" };
            }
            else
            {
                throw new PlantNotFoundException($"Map resolution not found for plant id { plantId }") { UserMessage = "Plant not found" };
            }

            return $"http://xxx{plantId}_{resoultion.ToString().ToLower()}.{format.ToString().ToLower()}";
        }
    }
}

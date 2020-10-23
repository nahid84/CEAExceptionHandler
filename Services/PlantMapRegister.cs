using Services.Models;
using System.Collections.Generic;

namespace Services
{
    internal class PlantMapRegister
    {
        public static Dictionary<int, List<PlantMapResolution>> MapResolutions = new Dictionary<int, List<PlantMapResolution>>
        {
            {1, new List<PlantMapResolution> { PlantMapResolution.Low, PlantMapResolution.Medium } },
            {2, new List<PlantMapResolution> { PlantMapResolution.Medium, PlantMapResolution.High } },
            {3, null }
        };

        public static Dictionary<int, List<PlantMapFormat>> MapFormats = new Dictionary<int, List<PlantMapFormat>>
        {
            {1, new List<PlantMapFormat> { PlantMapFormat.JPG, PlantMapFormat.PDF } },
            {2, new List<PlantMapFormat> { PlantMapFormat.PDF } }
        };

        public static bool IsPlantExists(int plantId)
        {
            return MapResolutions.ContainsKey(plantId) && MapFormats.ContainsKey(plantId);
        }
    }
}

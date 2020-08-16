using System.Net;

namespace CEASystemExceptions
{
    public class PlantNotFoundException : CEAException
    {
        public PlantNotFoundException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.NotFound;
        }
    }
}

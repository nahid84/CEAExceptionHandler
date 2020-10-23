using System.Net;

namespace Exceptions
{
    public class PlantNotFoundException : BaseException
    {
        public PlantNotFoundException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.NotFound;
        }
    }
}

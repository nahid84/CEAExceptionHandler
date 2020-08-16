using System.Net;

namespace CEASystemExceptions
{
    public class InvalidResolutionException : CEAException
    {
        public InvalidResolutionException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }
    }
}

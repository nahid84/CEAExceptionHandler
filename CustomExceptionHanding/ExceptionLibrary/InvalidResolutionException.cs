using System.Net;

namespace Exceptions
{
    public class InvalidResolutionException : BaseException
    {
        public InvalidResolutionException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }
    }
}

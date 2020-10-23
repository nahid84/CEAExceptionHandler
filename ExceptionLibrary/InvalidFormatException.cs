using System.Net;

namespace Exceptions
{
    public class InvalidFormatException : BaseException
    {
        public InvalidFormatException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }
    }
}

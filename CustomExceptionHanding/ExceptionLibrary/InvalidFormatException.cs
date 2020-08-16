using System.Net;

namespace CEASystemExceptions
{
    public class InvalidFormatException : CEAException
    {
        public InvalidFormatException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }
    }
}

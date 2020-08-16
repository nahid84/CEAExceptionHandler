using System.Net;

namespace CEASystemExceptions
{
    public class UnknownException : CEAException
    {
        public UnknownException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.InternalServerError;
        }
    }
}

using System.Net;

namespace Exceptions
{
    public class UnknownException : BaseException
    {
        public UnknownException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.InternalServerError;
        }
    }
}

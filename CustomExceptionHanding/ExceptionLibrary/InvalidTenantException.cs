using System.Net;

namespace Exceptions
{
    public class InvalidTenantException : BaseException
    {
        public InvalidTenantException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.Forbidden;
        }
    }
}

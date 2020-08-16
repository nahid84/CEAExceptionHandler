using System.Net;

namespace CEASystemExceptions
{
    public class InvalidTenantException : CEAException
    {
        public InvalidTenantException(string devMessage) : base(devMessage)
        {
            StatusCode = HttpStatusCode.Forbidden;
        }
    }
}

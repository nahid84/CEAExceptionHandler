using Newtonsoft.Json;
using System.Net;

namespace ExceptionDealer.Exceptions
{
    public class UserException
    {
        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

using CEASystemExceptions;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDealer.Exceptions
{
    public class ExceptionWriter
    {
        private const string CONTENT_TYPE = "application/json";

        public static Task WriteUserExceptionResponse(HttpResponse response, CEAException ex)
        {
            response.StatusCode = (int) ex.StatusCode;
            response.ContentType = CONTENT_TYPE;

            var userEx = new UserException
            {
                StatusCode = ex.StatusCode,
                Message = ex.UserMessage
            };

            return response.WriteAsync(userEx.ToString(), Encoding.UTF8);
        }
    }
}

using System;
using System.Net;

namespace Exceptions
{
    public class BaseException : Exception
    {
        public HttpStatusCode StatusCode { get; protected set; }

        public string UserMessage { get; set; }

        public BaseException(string message) : base(message) { }
    }
}

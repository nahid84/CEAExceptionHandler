using System;
using System.Net;

namespace CEASystemExceptions
{
    public class CEAException : Exception
    {
        public HttpStatusCode StatusCode { get; protected set; }

        public string UserMessage { get; set; }

        public CEAException(string message) : base(message) { }
    }
}

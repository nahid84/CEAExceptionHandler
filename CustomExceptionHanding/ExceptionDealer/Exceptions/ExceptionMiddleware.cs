using CEASystemExceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ExceptionDealer.Exceptions
{
    public class ExceptionMiddleware
    {
        private const string UNKOWN_EX_MESSAGE = "Something went wrong";

        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                if (ex is CEAException)
                {
                    await HandleException(context, ex as CEAException);
                } 
                else
                {
                    await HandleException(context, 
                                          new UnknownException(UNKOWN_EX_MESSAGE) { UserMessage = UNKOWN_EX_MESSAGE} as CEAException);
                }
            }
        }

        private Task HandleException(HttpContext context, CEAException ex)
        {
            return ExceptionWriter.WriteUserExceptionResponse(context.Response, ex);
        }
    }
}

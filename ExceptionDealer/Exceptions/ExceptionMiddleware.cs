using Exceptions;
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
                if (ex is BaseException)
                {
                    await HandleException(context, ex as BaseException);
                } 
                else
                {
                    await HandleException(context, 
                                          new UnknownException(UNKOWN_EX_MESSAGE) { UserMessage = UNKOWN_EX_MESSAGE} as BaseException);
                }
            }
        }

        private Task HandleException(HttpContext context, BaseException ex)
        {
            return ExceptionWriter.WriteUserExceptionResponse(context.Response, ex);
        }
    }
}

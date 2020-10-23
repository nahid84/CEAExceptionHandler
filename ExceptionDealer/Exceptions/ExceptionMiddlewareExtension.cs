using Microsoft.AspNetCore.Builder;

namespace ExceptionDealer.Exceptions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void UseCEAExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}

using Microsoft.AspNetCore.Diagnostics;

namespace CQRSMediatRExample.API.Extensions
{
    public class OrExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
            Exception exception, 
            CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = 501;
            httpContext.Response.ContentType = "text/plain";

            await httpContext.Response.WriteAsync($"Exception Thrown...sorry. {exception.Message}");

            return true;
        }
    }
}

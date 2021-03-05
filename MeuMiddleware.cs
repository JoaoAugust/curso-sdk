using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MeuMiddleware
    {

        private readonly RequestDelegate _next;
        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("\n\r ---------Antes -------- \n\r");

            await _next(context);

            Console.WriteLine("\n\r ---------Depois-------- \n\r");
        }
    }

    public static class MeuMiddlewareExtensio
    {
        public static IApplicationBuilder UseMeuMiddlerware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MeuMiddleware>();
        }

    }
}
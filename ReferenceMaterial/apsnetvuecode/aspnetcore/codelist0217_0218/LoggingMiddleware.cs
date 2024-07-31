namespace codelist0217_0218
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Threading.Tasks;

    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 在请求处理之前执行的逻辑
            Console.WriteLine($"Request: {context.Request.Path}");

            await _next(context);

            // 在请求处理之后执行的逻辑
            Console.WriteLine($"Response: {context.Response.StatusCode}");
        }
    }
}

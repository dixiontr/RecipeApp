using System.Diagnostics;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using RecipeApp.Core.Wrappers.Exception;
using Serilog;

namespace RecipeApp.Core.Application.Middlewares
{

    public class ExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger _logger;

        public ExceptionHandlingMiddleware(ILogger logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message,ex);
                await HandleErrorFromMiddleware(context);
            }
        }
        
        private async Task HandleErrorFromMiddleware(HttpContext context)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.OK;
            var result = JsonSerializer.Serialize(new UnhandledException().HandleException());
            await response.WriteAsync(result);
            
        }
    }

}
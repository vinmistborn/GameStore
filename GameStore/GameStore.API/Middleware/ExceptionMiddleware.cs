using Ardalis.GuardClauses;
using GameStore.Domain.Exceptions.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameStore.API.Middleware
{
    public class ExceptionMiddleware
    {
        public ExceptionMiddleware(RequestDelegate next,
                                  ILogger<ExceptionMiddleware> logger,
                                  IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                _logger.LogError(error, error.Message);
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new ErrorDetails();

                if (_env.IsDevelopment())
                {
                    context.Response.StatusCode = error switch
                    {
                        ArgumentException => (int)HttpStatusCode.BadRequest,
                        NotFoundException => (int)HttpStatusCode.NotFound,
                        BadRequestBaseException => (int)HttpStatusCode.BadRequest,
                        _ => (int)HttpStatusCode.InternalServerError
                    };

                    responseModel.StatusCode = context.Response.StatusCode;
                    responseModel.Message = error.Message;
                }


                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

                var json = JsonSerializer.Serialize(responseModel, options);

                await context.Response.WriteAsync(json);
            }
        }
    }

}

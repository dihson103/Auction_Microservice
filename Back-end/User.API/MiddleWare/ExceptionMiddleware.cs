﻿using User.Application.Exceptions;

namespace User.API.MiddleWare
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(UserException excepion)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = excepion.StatusCode;
                var error = new
                {
                    Status = excepion.StatusCode,
                    Message = excepion.Message
                };

                await context.Response.WriteAsJsonAsync(error);
            }
            catch(Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var error = new
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Message = "There is something wrong!"
                };

                await context.Response.WriteAsJsonAsync(error);
            }
        }
    }
}

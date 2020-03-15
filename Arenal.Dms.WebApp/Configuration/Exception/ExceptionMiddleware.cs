using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Arenal.Dms.WebApp.Configuration
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (exception.GetType() == typeof(DbUpdateException))
            {
                var sqlEx = exception?.InnerException as SqlException;

                if (sqlEx != null)
                {
                    var xx = sqlEx.Number;
                }
            }

            return context.Response.WriteAsync(new ErrorDetails()
            {
                Message = "Decko Greska Si",
                StatusCode = context.Response.StatusCode
            }.ToString());
        }
    }

    

    public static class ExceptionConfig
    {
        public static void CustomExceptionConfig(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}

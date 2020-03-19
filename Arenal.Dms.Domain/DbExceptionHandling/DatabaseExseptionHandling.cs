using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Arenal.Dms.Domain
{
    public class DatabaseExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public DatabaseExceptionMiddleware(RequestDelegate next)
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

            return context.Response.WriteAsync(new DatabaseExceptionModel
            {
                Message = "Decko Greska Si",
                StatusCode = context.Response.StatusCode
            }.ToString());
        }
    }

    public static class DatabaseExceptionConfig
    {
        public static void DatabaseExceptionConfiguration(this IApplicationBuilder app)
        {
            app.UseMiddleware<DatabaseExceptionMiddleware>();
        }
    }
}
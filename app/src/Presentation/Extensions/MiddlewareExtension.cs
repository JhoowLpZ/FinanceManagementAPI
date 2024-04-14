using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Presentation.Extensions
{
    public static class MiddlewareExtension
    {
        public static void RegisterMiddlewares(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseOpenApi();
                app.UseSwaggerUi(config =>
                {
                    config.DocumentTitle = "FinanceManagementAPI";
                    config.Path = "/swagger";
                    config.DocumentPath = "/swagger/{documentName}/swagger.json";
                    config.DocExpansion = "list";
                });
            }
        }
    }
}
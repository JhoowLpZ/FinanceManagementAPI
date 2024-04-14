using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Extensions
{
    public static class OpenAPIExtension
    {
        public static void RegisterOpenAPI(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddOpenApiDocument(config =>
            {
                config.DocumentName = "FinanceManagementAPI";
                config.Title = "FinanceManagementAPI v1";
                config.Version = "v1";
            });
        }
    }
}

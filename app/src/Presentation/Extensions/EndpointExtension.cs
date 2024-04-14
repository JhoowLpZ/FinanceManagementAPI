using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Presentation.Endpoints;
using System.Reflection;

namespace Presentation.Extensions
{
    public static class EndpointExtension
    {
        public static void MapEndpoints(this WebApplication app)
        {
            using (var serviceScope = app.Services.CreateScope())
            {
                var endpoints = serviceScope.ServiceProvider.GetServices<IEndpoint>();

                foreach (var endpoint in endpoints)
                {
                    endpoint.MapEndpoints(app);
                }
            }
        }

        public static void RegisterEndpoints(this IServiceCollection services)
        {
            ServiceDescriptor[] serviceDescriptors = typeof(IEndpoint).Assembly
                .GetTypes()
                .Where(p => p.IsClass && p.IsAssignableTo(typeof(IEndpoint)))
                .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint), type))
                .ToArray();

            services.TryAddEnumerable(serviceDescriptors);
        }
    }
}

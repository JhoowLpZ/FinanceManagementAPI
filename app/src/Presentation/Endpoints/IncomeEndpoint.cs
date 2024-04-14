using Application.Interfaces.Inputs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Presentation.Endpoints
{
    public class IncomeEndpoint : IEndpoint
    {
        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/incomes", (IIncomeUseCase _useCase) => {
                return _useCase.GetIncomeListAsync();
            });
        }
    }
}

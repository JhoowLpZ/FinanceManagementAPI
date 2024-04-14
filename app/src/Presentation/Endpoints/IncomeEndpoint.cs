
using Application.Interfaces.Inputs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Presentation.Endpoints
{
    public class IncomeEndpoint : IEndpoint
    {
        private readonly IIncomeUseCase _useCase;
        public IncomeEndpoint(IIncomeUseCase useCase)
        {
            _useCase = useCase;
        }

        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/incomes", () => {
                _useCase.GetIncomeListAsync();
            });
        }
    }
}

using Application.Interfaces.Inputs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Presentation.Endpoints
{
    public class ExpenseEndpoint : IEndpoint
    {
        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/expenses", (IExpenseUseCase _useCase) => {
                return _useCase.GetExpenseListAsync();
            });
        }
    }
}

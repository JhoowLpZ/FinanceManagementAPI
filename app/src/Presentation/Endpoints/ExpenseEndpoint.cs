
using Application.Interfaces.Inputs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Presentation.Endpoints
{
    public class ExpenseEndpoint : IEndpoint
    {
        private readonly IExpenseUseCase _useCase;
        public ExpenseEndpoint(IExpenseUseCase useCase)
        {
            _useCase = useCase;
        }

        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/expenses", () => {
                _useCase.GetExpenseListAsync().Wait();
            });
        }
    }
}

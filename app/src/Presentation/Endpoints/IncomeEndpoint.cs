using Domain.Entities;
using Application.Interfaces.Inputs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace Presentation.Endpoints
{
    public class IncomeEndpoint : IEndpoint
    {
        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/incomes", (IIncomeUseCase _useCase) => {
                return _useCase.GetIncomeListAsync();
            }).WithTags("Income");

            endpoints.MapGet("/incomes/{id}", (IIncomeUseCase _useCase, int id) => {
                return _useCase.GetIncomeByIdAsync(id);
            }).WithTags("Income");

            endpoints.MapPost("/incomes", (IIncomeUseCase _useCase, Income incomeRequest) => {
                return _useCase.InsertAsync(incomeRequest);
            }).WithTags("Income");

            endpoints.MapPut("/incomes/{id}", (IIncomeUseCase _useCase, Income incomeRequest, int id) => {
                return _useCase.UpdateAsync(incomeRequest, id);
            }).WithTags("Income");

            endpoints.MapDelete("/incomes/{id}", (IIncomeUseCase _useCase, int id) => {
                return _useCase.DeleteAsync(id);
            }).WithTags("Income");
        }
    }
}

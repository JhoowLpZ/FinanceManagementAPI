using Domain.Entities;
using Application.Interfaces.Inputs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace Presentation.Endpoints
{
    public class ExpenseEndpoint : IEndpoint
    {
        public void MapEndpoints(IEndpointRouteBuilder endpoints)
        {

            endpoints.MapGet("/expenses", async (IExpenseUseCase _useCase) => {
                return await _useCase.GetExpenseListAsync();
            }).WithTags("Expense");

            endpoints.MapGet("/expenses/{id}", async (IExpenseUseCase _useCase, int id) => {
                return await _useCase.GetExpenseByIdAsync(id);
            }).WithTags("Expense");

            endpoints.MapPost("/expenses", async (IExpenseUseCase _useCase, Expense expenseResquest) =>
            {
                return await _useCase.InsertAsync(expenseResquest);
            }).WithTags("Expense");

            endpoints.MapPut("/expenses/{id}", async (IExpenseUseCase _useCase, Expense expenseResquest, int id) => {
                return await _useCase.UpdateAsync(expenseResquest, id);
            }).WithTags("Expense");

            endpoints.MapDelete("/expenses/{id}", async (IExpenseUseCase _useCase, int id) => {
                return await _useCase.DeleteAsync(id);
            }).WithTags("Expense");
        }
    }
}

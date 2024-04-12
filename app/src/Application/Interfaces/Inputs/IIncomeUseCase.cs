﻿using Domain.Entities;

namespace Application.Interfaces.Inputs
{
    internal interface IIncomeUseCase
    {
        Task<IEnumerable<Income>> GetIncomeListAsync();
        Task<Income> GetIncomeByIdAsync(int Id);
        Task<Income> InsertAsync(Income income);
        Task<bool> DeleteAsync(int Id);
    }
}
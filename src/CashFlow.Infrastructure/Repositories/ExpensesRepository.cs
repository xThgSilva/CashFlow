﻿using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrastructure.DataAccess;

namespace CashFlow.Infrastructure.Repositories;

internal class ExpensesRepository : IExpensesRepository
{
    private readonly CashFlowDbContext _dbContext;

    public ExpensesRepository(CashFlowDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddExpense(Expense expense)
    {
        _dbContext.Expenses.Add(expense);
    }
}

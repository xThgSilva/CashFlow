using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.Repositories;

internal class ExpensesRepository : IExpensesRepository
{
    private readonly CashFlowDbContext _dbContext;

    public ExpensesRepository(CashFlowDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddExpense(Expense expense)
    {
        await _dbContext.Expenses.AddAsync(expense);
    }

    public async Task<IList<Expense>> GetAllExpenses()
    {
       return await _dbContext.Expenses.AsNoTracking().ToListAsync();
    }

    public Task<Expense?> GetById(long id)
    {
        return _dbContext.Expenses.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
    }
}

using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesRepository
{
    Task AddExpense(Expense expense);
    Task<IList<Expense>> GetAllExpenses();
    Task<Expense?> GetById(long id);
}

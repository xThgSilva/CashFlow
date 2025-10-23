using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories;
public interface IExpensesRepository
{
    public void AddExpense(Expense expense);
}

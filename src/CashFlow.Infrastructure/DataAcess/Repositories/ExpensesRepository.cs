using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAcess.Repositories;
internal class ExpensesRepository : IExpensesRepository
{
    public void Add(Expense expense)
    {
        var dbContext = new CashflowDbContext(); 

        dbContext.expenses.Add(expense); 

        dbContext.SaveChanges();
    }
}

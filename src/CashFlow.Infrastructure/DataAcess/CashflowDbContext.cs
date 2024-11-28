using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAcess;
internal class CashflowDbContext : DbContext
{
    public DbSet<Expense> expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowb;Uid=root;Pwd=@Password123";

        var version = new Version(8, 0, 40);
        var ServerVersion = new MySqlServerVersion(version);

        optionsBuilder.UseMySql(connectionString, ServerVersion);
    }
}

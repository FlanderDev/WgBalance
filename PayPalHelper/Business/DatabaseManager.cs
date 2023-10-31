using Microsoft.EntityFrameworkCore;
using PayPalHelper.Database;
using PayPalHelper.Model;
using System.Numerics;

namespace PayPalHelper.Business;

internal static class DatabaseManager
{
    public static List<PpTransaction> GetPayPalTransaction()
    {
        using var dbContext = new DatabaseContext();
        return dbContext.Transactions.AsNoTracking().ToList();
    }


    public static List<Tenant> GetTenants()
    {
        using var dbContext = new DatabaseContext();
        return dbContext.Tenants.AsNoTracking().ToList();
    }

    public static int AddTransactions(List<PpTransaction> newTransaction)
    {
        using var dbContext = new DatabaseContext();
        dbContext.Transactions.AddRange(newTransaction);
        return dbContext.SaveChanges();
    }

    public static int ClearTransactions()
    {
        using var dbContext = new DatabaseContext();
        return dbContext.Transactions.ExecuteDelete();
    }

    public static bool CreateDatabase()
    {
        using var db = new DatabaseContext();
        return db.Database.EnsureCreated();
    }

    public static bool DeleteDatabase()
    {
        using var db = new DatabaseContext();
        return db.Database.EnsureDeleted();
    }
}
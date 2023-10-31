using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using PayPalHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PayPalHelper.Database;

public class DatabaseContext : DbContext
{
    /// <summary>
    /// Sets the path of the Database files.
    /// </summary>
    /// <param name="optionsBuilder">Provides the usage of <see cref="SqliteDbContextOptionsBuilderExtensions.UseSqlite"/></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Directory.CreateDirectory(@"Database");
        optionsBuilder.UseSqlite(@"FileName=Database\Database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tenant>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }

    internal DbSet<Tenant> Tenants => Set<Tenant>();
    internal DbSet<PpTransaction> Transactions => Set<PpTransaction>();
}
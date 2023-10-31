using AuditHelper.Data;
using AuditHelper.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHelper.Buisness;

internal static class DatabaseManager
{
    public static Person? GetPersonById(int id)
    {
        using var dbContext = new DatabaseContext();
        return dbContext.People.AsNoTracking().FirstOrDefault(p => p.Id == id);
    }

    public static bool AddNewPerson(Person person)
    {
        try
        {
            using var dbContext = new DatabaseContext();
            dbContext.Add(person);
            dbContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool RemovePerson(Person person)
    {
        try
        {
            using var dbContext = new DatabaseContext();
            dbContext.Remove(person);
            dbContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
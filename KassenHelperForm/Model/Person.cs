using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHelper.Model;

internal class Person
{
    public Person(string name)
    {
        Name = name;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Purchase> Purchases { get; set; } = new();
    public List<Payment> Payments { get; set; } = new();
}

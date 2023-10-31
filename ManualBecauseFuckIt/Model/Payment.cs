using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualBecauseFuckIt.Model;

internal class Payment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Person Person { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateTime { get; set; }


    public Payment()
    {
    }

    public Payment(Person person, decimal amount, DateTime dateTime)
    {
        Person = person;
        Amount = amount;
        DateTime = dateTime;
    }
}

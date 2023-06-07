using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KassenHelper.Model;

internal class Purchase
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? FileLocation { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
    public decimal Payed { get; set; }
    public DateTime Created { get; set; }


    public Purchase()
    {

    }

    public Purchase(string? fileLocation, decimal payed, DateTime received, List<Item> items)
    {
        FileLocation = fileLocation;
        Payed = payed;
        Created = received;
        Items = items;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManualBecauseFuckIt.Model;

internal class Purchase
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? FileLocation { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
    public DateTime Created { get; set; }


    public Purchase()
    {
    }

    public Purchase(string? fileLocation, DateTime received, List<Item> items)
    {
        FileLocation = fileLocation;
        Created = received;
        Items = items;
    }

    public decimal PurchasePrice() => Items.Sum(i => i.Price);
}

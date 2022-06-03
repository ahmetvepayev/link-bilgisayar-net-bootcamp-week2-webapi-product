using System.ComponentModel.DataAnnotations.Schema;
using Week2.Api.Entities.Abstract;

namespace Week2.Api.Entities.Concrete;

public class Product : IEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; }

    public decimal UnitPrice { get; set; }

    public short StockAmount { get; set; }
}
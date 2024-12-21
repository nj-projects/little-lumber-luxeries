using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Colour { get; set; }
    public string Wood { get; set; }
    public string Size { get; set; }
    public string ImageUrl { get; set; }

    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}
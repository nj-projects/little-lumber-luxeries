namespace AuctionService.DTOs;

public class AuctionDto
{
    public Guid Id { get; set; }
    public Decimal ReservePrice { get; set; }
    public string Seller { get; set; }
    public string Winner { get; set; }
    public Decimal SoldAmount { get; set; }
    public Decimal CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Colour { get; set; }
    public string Wood { get; set; }
    public string Size { get; set; }
    public string ImageUrl { get; set; }
}
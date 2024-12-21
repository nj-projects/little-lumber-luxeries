using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
    [Required] public string Colour { get; set; }
    [Required] public string Wood { get; set; }
    [Required] public string Size { get; set; }
    [Required] public string ImageUrl { get; set; }
    [Required] public decimal ReservePrice { get; set; }
    [Required] public DateTime AuctionEnd { get; set; }
}
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetRequiredService<AuctionDbContext>());
    }

    private static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
            // 1 
            new Auction
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    Name = "T-rex Dinosaur",
                    Description = "T-rex Dinosaur - Ideal as a decorative item in a kids bedroom",
                    Colour = "Green",
                    Wood = "Plywood",
                    Size = "42 x 65",
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            // 2 
            new Auction
            {
                Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
                Status = Status.Live,
                ReservePrice = 90000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(60),
                Item = new Item
                {
                    Name = "Candle Holder",
                    Description = "Candle Holder for 6 tea lights",
                    Colour = "Light Oak",
                    Wood = "Oak",
                    Size = "600 x 24",
                    ImageUrl = "https://cdn.pixabay.com/photo/2012/05/29/00/43/car-49278_960_720.jpg"
                }
            },
            // 3 
            new Auction
            {
                Id = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                Status = Status.Live,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item
                {
                    Name = "Shelf",
                    Description = "Free standing shelf",
                    Colour = "Unpainted",
                    Wood = "MDF",
                    Size = "2020 x 36",
                    ImageUrl = "https://cdn.pixabay.com/photo/2012/11/02/13/02/car-63930_960_720.jpg"
                }
            },
            // 4 
            new Auction
            {
                Id = Guid.Parse("155225c1-4448-4066-9886-6786536e05ea"),
                Status = Status.ReserveNotMet,
                ReservePrice = 50000,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(-10),
                Item = new Item
                {
                    Name = "Handcrafted Jewelry Box",
                    Description = "A beautifully handcrafted box with intricate carvings to store",
                    Colour = "Deep Mahogany",
                    Wood = "Mahogany",
                    Size = "8'x6'x4'",
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/04/17/22/10/mercedes-benz-1335674_960_720.png"
                }
            },
            // 5
            new Auction
            {
                Id = Guid.Parse("466e4744-4dc5-4987-aae0-b621acfc5e39"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    Name = "Custom Wooden Picture Frame",
                    Description = "A personalized wooden frame to display cherished memories.",
                    Colour = "Natural Oak",
                    Wood = "Oak",
                    Size = "10'x8",
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/08/31/05/47/bmw-2699538_960_720.jpg"
                }
            },
            // 6 
            new Auction
            {
                Id = Guid.Parse("dc1e4071-d19d-459b-b848-b5c3cd3d151f"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(45),
                Item = new Item
                {
                    Name = "Rustic Wooden Coasters",
                    Description = "A set of four coasters made from reclaimed wood with a rustic finish.",
                    Colour = "Weathered Grey",
                    Wood = "Reclaimed Barn Wood",
                    Size = "4'x4",
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/11/09/01/49/ferrari-458-spider-2932191_960_720.jpg"
                }
            },
            // 7
            new Auction
            {
                Id = Guid.Parse("47111973-d176-4feb-848d-0ea22641c31a"),
                Status = Status.Live,
                ReservePrice = 150000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(13),
                Item = new Item
                {
                    Name = "Wooden Desk Organizer",
                    Description = "An elegant desk organizer with compartments for stationery and accessories.",
                    Colour = "Rich Cherry",
                    Wood = "Cherry",
                    Size = "12'x6'x4",
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/11/08/14/39/ferrari-f430-2930661_960_720.jpg"
                }
            },
            // 8 
            new Auction
            {
                Id = Guid.Parse("6a5011a1-fe1f-47df-9a32-b5346b289391"),
                Status = Status.Live,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(19),
                Item = new Item
                {
                    Name = "Engraved Cutting Board",
                    Description = "A durable and stylish cutting board with custom engravings.",
                    Colour = "Warm Walnut",
                    Wood = "Walnut",
                    Size = "18'x12",
                    ImageUrl = "https://cdn.pixabay.com/photo/2019/12/26/20/50/audi-r8-4721217_960_720.jpg"
                }
            },
            // 9 
            new Auction
            {
                Id = Guid.Parse("40490065-dac7-46b6-acc4-df507e0d6570"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(20),
                Item = new Item
                {
                    Name = "Handcrafted Wine Holder",
                    Description = "A unique wooden wine holder with a modern design, perfect for wine enthusiasts.",
                    Colour = "Light Maple",
                    Wood = "Maple",
                    Size = "14'x5'x5",
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/09/01/15/06/audi-1636320_960_720.jpg"
                }
            },
            // 10
            new Auction
            {
                Id = Guid.Parse("3659ac24-29dd-407a-81f5-ecfe6f924b9b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(48),
                Item = new Item
                {
                    Name = "Personalized Wooden Keychain",
                    Description =
                        "A small yet meaningful gift, this keychain can be engraved with initials or a special message.",
                    Colour = "Golden Pine",
                    Wood = "Pine",
                    Size = "3'x1'x0.5",
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/08/02/19/47/vintage-2573090_960_720.jpg"
                }
            }
        };

        context.AddRange(auctions);
        context.SaveChanges();
    }
}
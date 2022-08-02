using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Data
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    AuctionId = Guid.NewGuid().ToString(),
                    ProductId = Guid.NewGuid().ToString(),
                    SellerUserName = "test@test.com",
                    UnitPrice = 10,
                    TotalPrice = 1000,
                    CreatedAt = DateTime.UtcNow
                },
                new Order()
                {
                    AuctionId = Guid.NewGuid().ToString(),
                    ProductId = Guid.NewGuid().ToString(),
                    SellerUserName = "test1@test1.com",
                    UnitPrice = 89,
                    TotalPrice = 899,
                    CreatedAt = DateTime.UtcNow
                },
                new Order()
                {
                    AuctionId = Guid.NewGuid().ToString(),
                    ProductId = Guid.NewGuid().ToString(),
                    SellerUserName = "test2@test2.com",
                    UnitPrice = 49,
                    TotalPrice = 999,
                    CreatedAt = DateTime.UtcNow
                },
                new Order()
                {
                    AuctionId = Guid.NewGuid().ToString(),
                    ProductId = Guid.NewGuid().ToString(),
                    SellerUserName = "test3@test3.com",
                    UnitPrice = 25,
                    TotalPrice = 1000,
                    CreatedAt = DateTime.UtcNow
                },
                new Order()
                {
                    AuctionId = Guid.NewGuid().ToString(),
                    ProductId = Guid.NewGuid().ToString(),
                    SellerUserName = "test4@test4.com",
                    UnitPrice = 50,
                    TotalPrice = 5000,
                    CreatedAt = DateTime.UtcNow
                }
            };
        }
    }
}

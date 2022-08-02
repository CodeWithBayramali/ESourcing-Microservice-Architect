using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esourcing.Sourcing.Data
{
    public class SourcingContextSeed
    {
        public static void SeedData(IMongoCollection<Auction> auctionCollection)
        {
            bool exist = auctionCollection.Find(p => true).Any();

            if (!exist)
            {
                auctionCollection.InsertManyAsync(GetPreconfiguredAuctions());
            }
        }

        private static IEnumerable<Auction> GetPreconfiguredAuctions()
        {
            return new List<Auction>()
            {
               new Auction()
                {
                    Name="Auction 1",
                    Description="Auction Description Ready",
                    CreatedAt=DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(10),
                    ProductId="62e049c3bd7434ec2e3afb72",
                    IncludedSellers = new List<string>()
                    {
                        "seller1",
                        "seller2",
                        "seller3"
                    },
                    Quantity= 5,
                    Status=(int)Status.Active
                },
                new Auction()
                {
                    Name="Auction 2",
                    Description="Auction Description Ready",
                    CreatedAt=DateTime.Now,
                    StartedAt=DateTime.Now,
                    FinishedAt=DateTime.Now.AddDays(10),
                    ProductId="62e049c3bd7434ec2e3afb74",
                    IncludedSellers = new List<string>()
                    {
                        "Seller Bey 1",
                        "Seller Bey 2",
                        "Seller Bey 3"
                    },
                    Quantity= 8,
                    Status=(int)Status.Passive
                }
            };
        }
    }
}

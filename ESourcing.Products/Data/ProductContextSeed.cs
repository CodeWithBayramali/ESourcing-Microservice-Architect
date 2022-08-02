using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProduct());
            }
        }

        private static IEnumerable<Product> GetConfigureProduct()
        {
            return new List<Product>()
            {
                new Product{Name="Huawei P30",Price=10000.00M,Description="Bu telefon bir harika dostum",ImageFile="product-5.png",Category="Phone",Summary="Harika"},
                new Product{Name="Infinix INBOOK",Price=8500.15M,Description="Son model bu laptopa siz de sahip olmalısınız.", ImageFile="product-5.png",Category="TV",Summary="Harika"},
                new Product{Name="Iphone X",Price=11899.00M,Description="En son çıkan bu iphone bir harika dostum",ImageFile="product-5.png",Category="Phone",Summary="Harika"},
                new Product{Name="HP Pavilion 15-DK1056WM",Price=8500.12M,Description="Harika seçenekler ile cok yakında stoklarımızda",ImageFile="product-5.png",Category="Phone",Summary="Harika"},
                new Product{Name="Fair & Clear",Price=12000.99M,Description="Bu telefon bir harika dostum",ImageFile="product-5.png",Category="Phone",Summary="Harika"},
                new Product{Name="AMD Ryzen 5 6500X",Price=6589.00M,Description="Bu telefon bir harika dostum",ImageFile="product-5.png",Category="Phone",Summary="Harika"}
            };
        }
    }
}

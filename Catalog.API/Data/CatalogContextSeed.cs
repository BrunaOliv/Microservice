using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p=> true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product> { 
                new Product()
                {
                    Id = "bb62d79b-99a4-45a3-b22d-eebabb772fe2",
                    Name = "IPhone X",
                    Description = "The purpose of lorem ipsum is to create a natural looking block of text (sentence, paragraph, page, etc.) that doesn't distract from the layout. A practice not without controversy, laying out pages with meaningless filler text can be very useful when the focus is meant to be on design, not content.",
                    Image = "product-1.png",
                    Price = "950.00M",
                    Category ="Smart Phone"
                }
            }
        }
    }
}

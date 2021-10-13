using MarketApp.DAL.EF;
using MarketApp.DAL.Entities;
using MarketApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MarketApp.DAL.Repositories
{
    class ProductRepository : IProductRepository
    {
        private readonly MarketAppContext db;
        public ProductRepository(MarketAppContext db)
        {
            this.db = db;
        }
        public void Create(Product product)
        {
            db.Add(product);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);

            if (product != null)
            {
                db.Products.Remove(product);
            }
        }

        public IEnumerable<Product> GetProductsFromShop(int shopId)
        {
            return db.Products.Where(p => p.ShopId == shopId);
        }

        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }
    }
}

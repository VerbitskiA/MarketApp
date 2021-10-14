using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductsFromShop(int shopId);
        Product GetOneById(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}

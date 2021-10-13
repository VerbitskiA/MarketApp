using MarketApp.DAL.Entities;
using MarketApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Repositories
{
    class ProductRepository : IRepository<Product>
    {
        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}

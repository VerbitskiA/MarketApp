using MarketApp.DAL.Entities;
using MarketApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Repositories
{
    class ShopRepository : IRepository<Shop>
    {
        public void Create(Shop item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shop> Find(Func<Shop, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Shop> GetAll()
        {
            throw new NotImplementedException();
        }

        public Shop GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shop item)
        {
            throw new NotImplementedException();
        }
    }
}

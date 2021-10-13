using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Interfaces
{
    public interface IShopRepository
    {
        IEnumerable<Shop> GetAllShops();
        Shop GetOneById(int id);
        IEnumerable<Shop> Find(Func<Shop, Boolean> predicate);
        void Create(Shop shop);
        void Update(Shop shop);
        void Delete(int id);
    }
}

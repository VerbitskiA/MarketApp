using MarketApp.DAL.EF;
using MarketApp.DAL.Entities;
using MarketApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketApp.DAL.Repositories
{
    class ShopRepository : IShopRepository
    {
        private readonly MarketAppContext db;
        public ShopRepository(MarketAppContext db)
        {
            this.db = db;
        }
        public void Create(Shop shop)
        {
            db.Add(shop);
        }

        public void Delete(int id)
        {
            Shop shop = db.Shops.Find(id);

            if (shop != null)
            {
                db.Shops.Remove(shop);
            }
        }

        public IEnumerable<Shop> Find(Func<Shop, bool> predicate)
        {
            return db.Shops.Where(predicate);
        }

        public IEnumerable<Shop> GetAllShops()
        {
            return db.Shops;
        }

        public Shop GetOneById(int id)
        {
            return db.Shops.Find(id);
        }

        public void Update(Shop shop)
        {
            db.Entry(shop).State = EntityState.Modified;
        }
    }
}

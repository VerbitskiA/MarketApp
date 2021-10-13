using MarketApp.DAL.Entities;
using MarketApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Repositories
{
    class EFUnitOfWork : IUnitOfWork
    {
        public IRepository<Shop> Shops => throw new NotImplementedException();

        public IRepository<Product> Products => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

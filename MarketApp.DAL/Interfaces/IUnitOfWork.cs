using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shop> Shops { get; }

        IRepository<Product> Products { get; }

        void Save();
    }
}

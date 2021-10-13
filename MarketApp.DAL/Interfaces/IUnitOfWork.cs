using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IShopRepository Shops { get; }

        IProductRepository Products { get; }

        void Save();
    }
}

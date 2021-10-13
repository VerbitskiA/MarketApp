﻿using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductsFromShop(Shop shop);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
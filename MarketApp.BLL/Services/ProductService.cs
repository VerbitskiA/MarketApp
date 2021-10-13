using AutoMapper;
using MarketApp.BLL.DTO;
using MarketApp.BLL.Interfaces;
using MarketApp.DAL.Entities;
using MarketApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.BLL.Services
{
    public class ProductService : IProductService
    {
        IUnitOfWork db;
        public ProductService(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }
        public IEnumerable<ProductDTO> GetProductsDTOsFromShop(int shopId)
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(db.Products.GetProductsFromShop(shopId));
        }
    }
}

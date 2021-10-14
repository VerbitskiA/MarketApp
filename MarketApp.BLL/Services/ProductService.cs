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
        public void Delete(int id)
        {
            db.Products.Delete(id);
            db.Save();
        }

        public void Create(ProductDTO productDTO)
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, Product>()).CreateMapper();
            db.Products.Create(mapper.Map<ProductDTO, Product>(productDTO));
            db.Save();
        }

        public void Update(ProductDTO productDTO)
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, Product>()).CreateMapper();
            db.Products.Update(mapper.Map<ProductDTO, Product>(productDTO));
            db.Save();
        }

        public ProductDTO GetOneById(int id)
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            return mapper.Map<Product, ProductDTO>(db.Products.GetOneById(id));
        }
    }
}

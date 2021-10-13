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
    public class ShopService : IShopService
    {
        IUnitOfWork db;
        public ShopService(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }
        public IEnumerable<ShopDTO> GetShopDTOs()
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Shop, ShopDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Shop>, IEnumerable<ShopDTO>>(db.Shops.GetAllShops());
        }
    }
}

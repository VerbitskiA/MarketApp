
using MarketApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.BLL.Interfaces
{
    public interface IShopService
    {
        IEnumerable<ShopDTO> GetShopDTOs();
    }
}

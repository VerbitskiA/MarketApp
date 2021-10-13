using MarketApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.BLL.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetProductsDTOsFromShop(ShopDTO shopDTO);
    }
}

using MarketApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.BLL.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetProductsDTOsFromShop(int shopId);
        void Delete(int id);
        void Create(ProductDTO productDTO);
        void Update(ProductDTO productDTO);

        ProductDTO GetOneById(int id);
    }
}

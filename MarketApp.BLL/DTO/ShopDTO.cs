using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.BLL.DTO
{
    public class ShopDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Shedule { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}

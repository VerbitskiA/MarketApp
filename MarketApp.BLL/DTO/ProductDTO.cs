﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.BLL.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ShopId { get; set; }
        public ShopDTO Shop { get; set; }
    }
}

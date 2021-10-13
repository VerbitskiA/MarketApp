﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarketApp.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}

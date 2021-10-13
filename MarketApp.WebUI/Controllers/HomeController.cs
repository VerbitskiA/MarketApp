using AutoMapper;
using MarketApp.BLL.DTO;
using MarketApp.BLL.Interfaces;
using MarketApp.DAL.Interfaces;
using MarketApp.WebUI.Models;
using MarketAPP.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAPP.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        
        private IShopService shopService;
        private IProductService productService;

        public HomeController(ILogger<HomeController> logger, IShopService shopService, IProductService productService)
        {
            _logger = logger;
            this.shopService = shopService;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            IEnumerable<ShopDTO> shopDTOs = shopService.GetShopDTOs();

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ShopDTO, ShopViewModel>()).CreateMapper();

            List<ShopViewModel> shops = mapper.Map<IEnumerable<ShopDTO>, List<ShopViewModel>>(shopDTOs);

            return View(shops);
        }

        public IActionResult Privacy()
        {
            IEnumerable<ProductDTO> productDTOs = productService.GetProductsDTOsFromShop(1);

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();

            List<ProductViewModel> products = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(productDTOs);

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

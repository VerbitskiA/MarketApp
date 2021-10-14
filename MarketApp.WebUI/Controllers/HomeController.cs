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
        public IActionResult GetProducts(int id)
        {
            IEnumerable<ProductDTO> productDTOs = productService.GetProductsDTOsFromShop(id);

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();

            List<ProductViewModel> products = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(productDTOs);

            return View(products);
        }

        public IActionResult DeleteProduct(int id, int shopId)
        {
            productService.Delete(id);
            
            return RedirectToAction("GetProducts", new { id = shopId });
        }

        [HttpGet]
        public IActionResult CreateProduct(int shopId)
        {
            ViewBag.ShopId = shopId;
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel product)
        {

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductViewModel, ProductDTO>()).CreateMapper();
            productService.Create(mapper.Map<ProductViewModel, ProductDTO>(product));
            return RedirectToAction("GetProducts", new { id = product.ShopId });
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            ProductDTO productDTO = productService.GetOneById(id);

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();

            ProductViewModel product = mapper.Map<ProductDTO, ProductViewModel>(productDTO);

            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductViewModel product)
        {

            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductViewModel, ProductDTO>()).CreateMapper();
            productService.Update(mapper.Map<ProductViewModel, ProductDTO>(product));

            return RedirectToAction("GetProducts", new { id = product.ShopId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

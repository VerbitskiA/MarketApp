using MarketApp.DAL.EF;
using MarketApp.DAL.Interfaces;

namespace MarketApp.DAL.Repositories
{
    class EFUnitOfWork : IUnitOfWork
    {
        private readonly MarketAppContext db;        
        private ShopRepository shopRepository;
        private ProductRepository productRepository;
        public IShopRepository Shops
        {
            get
            {
                if (shopRepository is null)
                {
                    shopRepository = new ShopRepository(db);
                }
                return shopRepository;
            }
        }

        public IProductRepository Products
        {
            get
            {
                if (productRepository is null)
                {
                    productRepository = new ProductRepository(db);
                }
                return productRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

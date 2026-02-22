
namespace Catalog.Infrastructure.Repositories
{
    public class CatalogRepository :
        IBrandRepository,
        ICategoryRepository,
        ICatalogItemRepository
    {
        //IBrandRepository
        public Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            throw new NotImplementedException();
        }
        
        //ICategoryRepository
        public Task<IEnumerable<Category>> GetAllCategoriesAssync()
        {
            throw new NotImplementedException();
        }

        //ICatalogItemRepository
        public Task<CatalogItem> CreateCatalogItemAsync(CatalogItem item)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteCatalogItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogItem?> GetCatalogItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogItem>> GetCatalogItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogItem>> GetCatalogItemsByBrandAsync(string brandTitle)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogItem>> GetCatalogItemsByTitleAsync(string title)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCatalogItemAsync(CatalogItem item)
        {
            throw new NotImplementedException();
        }
    }
}

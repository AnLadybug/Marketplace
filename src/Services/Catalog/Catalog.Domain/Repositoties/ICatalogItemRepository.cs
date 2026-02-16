namespace Catalog.Domain.Repositoties
{
    internal interface ICatalogItemRepository
    {
        Task<CatalogItem> CreateCatalogItemAsync(CatalogItem item);
        Task<IEnumerable<CatalogItem>> GetCatalogItemsAsync();
        Task<CatalogItem?> GetCatalogItemAsync(Guid id);
    }
}

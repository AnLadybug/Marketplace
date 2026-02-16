namespace Catalog.Domain.Repositoties
{
    internal interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAssync();
    }
}

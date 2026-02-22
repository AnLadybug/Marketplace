namespace Catalog.Domain.Repositoties
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAssync();
    }
}

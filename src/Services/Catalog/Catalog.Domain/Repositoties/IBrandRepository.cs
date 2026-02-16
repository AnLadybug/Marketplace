namespace Catalog.Domain.Repositoties
{
    internal interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
    }
}

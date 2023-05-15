using MvcasyncProject.Dto;

namespace MvcasyncProject.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> GetAllProductAsync();
        Task<ProductDto> AddProductAsync(ProductDto productDto);
        Task<ProductDto> GetProductByIdAsync(int id);
        Task UpdateProductAsync(int id, ProductDto productDto);
        Task DeleteProductAsync(int id);
    }
}

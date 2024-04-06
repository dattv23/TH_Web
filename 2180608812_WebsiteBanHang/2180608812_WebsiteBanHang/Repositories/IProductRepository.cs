using _2180608812_WebsiteBanHang.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace _2180608812_WebsiteBanHang.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}

using _2180608812_WebsiteBanHang.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace _2180608812_WebsiteBanHang.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}

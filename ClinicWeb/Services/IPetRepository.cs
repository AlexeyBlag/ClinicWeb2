using ClinicWeb.Models;

namespace ClinicWeb.Services
{
    public interface IPetRepository
    {
        Task<List<Pet>> GetAllAsync();
        Task<Pet?> GetByIdAsync(int id);
        Task AddAsync(Pet pet);
        Task UpdateAsync(Pet pet);
        Task DeleteAsync(int id);
        Task<List<Pet>> GetByClientIdAsync(int clientId);
    }
}
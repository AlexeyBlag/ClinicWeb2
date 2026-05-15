using ClinicWeb.Models;

namespace ClinicWeb.Services
{
    public interface IVeterinarianRepository
    {
        Task<List<Veterinarian>> GetAllAsync();
        Task<Veterinarian?> GetByIdAsync(int id);
        Task AddAsync(Veterinarian veterinarian);
        Task UpdateAsync(Veterinarian veterinarian);
        Task DeleteAsync(int id);
    }
}
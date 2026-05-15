using Microsoft.EntityFrameworkCore;
using ClinicWeb.Data;
using ClinicWeb.Models;

namespace ClinicWeb.Services
{
    public class VeterinarianRepository : IVeterinarianRepository
    {
        private readonly AppDbContext _context;

        public VeterinarianRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Veterinarian>> GetAllAsync() =>
            await _context.Veterinarians.Include(v => v.Appointments).ToListAsync();

        public async Task<Veterinarian?> GetByIdAsync(int id) =>
            await _context.Veterinarians.Include(v => v.Appointments)
                .FirstOrDefaultAsync(v => v.Id == id);

        public async Task AddAsync(Veterinarian veterinarian)
        {
            await _context.Veterinarians.AddAsync(veterinarian);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Veterinarian veterinarian)
        {
            _context.Veterinarians.Update(veterinarian);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var veterinarian = await _context.Veterinarians.FindAsync(id);
            if (veterinarian != null)
            {
                _context.Veterinarians.Remove(veterinarian);
                await _context.SaveChangesAsync();
            }
        }
    }
}
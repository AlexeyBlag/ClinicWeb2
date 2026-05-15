using Microsoft.EntityFrameworkCore;
using ClinicWeb.Data;
using ClinicWeb.Models;

namespace ClinicWeb.Services
{
    public class PetRepository : IPetRepository
    {
        private readonly AppDbContext _context;

        public PetRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pet>> GetAllAsync()
        {
            return await _context.Pets
                .Include(p => p.Client)
                .ToListAsync();
        }

        public async Task<Pet?> GetByIdAsync(int id)
        {
            return await _context.Pets
                .Include(p => p.Client)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Pet pet)
        {
            await _context.Pets.AddAsync(pet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pet pet)
        {
            _context.Pets.Update(pet);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Pet>> GetByClientIdAsync(int clientId)
        {
            return await _context.Pets
                .Where(p => p.ClientId == clientId)
                .ToListAsync();
        }
    }
}
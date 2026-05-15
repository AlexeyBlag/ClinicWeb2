using Microsoft.EntityFrameworkCore;
using ClinicWeb.Data;
using ClinicWeb.Models;

namespace ClinicWeb.Services
{

    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return await _context.Clients.Include(c => c.Pets).ToListAsync();
        }

        public async Task<Client?> GetByIdAsync(int id)
        {
            return await _context.Clients.Include(c => c.Pets).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Console.WriteLine($"=== УДАЛЕНИЕ КЛИЕНТА ID: {id} ===");

            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                Console.WriteLine($"❌ Клиент с ID {id} НЕ НАЙДЕН!");
                throw new Exception($"Клиент с ID {id} не найден");
            }

            Console.WriteLine($"✓ Найден клиент: {client.FullName}");

            try
            {
                _context.Clients.Remove(client);
                Console.WriteLine($"✓ Клиент помечен на удаление");

                var rowsAffected = await _context.SaveChangesAsync();
                Console.WriteLine($"✓ Удалено записей: {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Ошибка при сохранении: {ex.Message}");
                throw;
            }
        }
    }
}
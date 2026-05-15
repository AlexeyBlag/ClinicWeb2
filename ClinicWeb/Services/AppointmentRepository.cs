using Microsoft.EntityFrameworkCore;
using ClinicWeb.Data;
using ClinicWeb.Models;

namespace ClinicWeb.Services
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Appointment>> GetAllAsync() =>
            await _context.Appointments
                .Include(a => a.Client)
                .Include(a => a.Pet)
                .Include(a => a.Veterinarian)
                .Include(a => a.MedicalRecord)
                .ToListAsync();

        public async Task<Appointment?> GetByIdAsync(int id) =>
            await _context.Appointments
                .Include(a => a.Client)
                .Include(a => a.Pet)
                .Include(a => a.Veterinarian)
                .Include(a => a.MedicalRecord)
                .FirstOrDefaultAsync(a => a.Id == id);

        public async Task AddAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> GetCountAsync() =>
            await _context.Appointments.CountAsync();
    }
}
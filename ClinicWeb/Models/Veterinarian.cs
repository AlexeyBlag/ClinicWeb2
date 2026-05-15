namespace  ClinicWeb.Models
{

    public class Veterinarian
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
namespace  ClinicWeb.Models
{

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty; 
        public string Breed { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }


        public int ClientId { get; set; }
        public Client? Client { get; set; }


        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
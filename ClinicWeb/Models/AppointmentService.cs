namespace  ClinicWeb.Models
{
    public class AppointmentService
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int ServiceId { get; set; }  

        public Appointment? Appointment { get; set; }
        public ClinicService? Service { get; set; }  
    }
}
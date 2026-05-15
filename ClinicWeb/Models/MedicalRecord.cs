namespace  ClinicWeb.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
        public string Treatment { get; set; } = string.Empty;
        public string Recommendations { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; }
        public string? Notes { get; set; }

        public int AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
    }
}
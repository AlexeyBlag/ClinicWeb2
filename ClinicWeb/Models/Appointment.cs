using ClinicWeb.Models;

public class Appointment
{
    public int Id { get; set; }

    public int ClientId { get; set; }
    public Client? Client { get; set; }

    public int? PetId { get; set; }
    public Pet? Pet { get; set; }

    public int VeterinarianId { get; set; }
    public Veterinarian? Veterinarian { get; set; }

    public DateTime AppointmentDate { get; set; }
    public string Reason { get; set; } = "";
    public string Status { get; set; } = "Запланировано";


    public string? Notes { get; set; }
    public decimal? Cost { get; set; }
    public string PaymentStatus { get; set; } = "Не оплачено";


    public int? MedicalRecordId { get; set; }
    public MedicalRecord? MedicalRecord { get; set; }
}
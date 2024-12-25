namespace Stella.Entity.Concrete
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; } // Randevu tarihi
        public int CustomerId { get; set; } // Randevu alan müşteri
        public int EmployeeId { get; set; } // Hizmeti sunan çalışan
        public int ServiceId { get; set; } // Alınan hizmet
        public bool IsConfirmed { get; set; } // Onay durumu
        public Employee Employee { get; set; }
        public Service Service { get; set; }
    }
}

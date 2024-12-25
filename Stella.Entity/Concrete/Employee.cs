namespace Stella.Entity.Concrete
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } // Çalışan adı
        public string Gender { get; set; } // Cinsiyet (Bay/Bayan)
        public string Specialization { get; set; } // Uzmanlık alanı (örn: Saç kesim, makyaj)
        public int SalonId { get; set; } // Hangi salona bağlı çalışıyor
        public Salon Salon { get; set; }
        public ICollection<Appointment> Appointments { get; set; } // Randevular
    }
}

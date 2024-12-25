namespace Stella.Entity.Concrete
{
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; } // Salon adı
        public string Address { get; set; } // Salon adresi
        public string PhoneNumber { get; set; } // İletişim numarası
        public string WorkingHours { get; set; } // Çalışma saatleri
        public ICollection<Employee> Employees { get; set; } // Çalışanlar
        public ICollection<Service> Services { get; set; } // Hizmetler
    }
}

namespace Stella.Entity.Concrete
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } // Hizmet adı (örn: Saç kesimi)
        public decimal Price { get; set; } // Ücreti
        public int DurationInMinutes { get; set; } // Süresi (dakika)
        public int SalonId { get; set; } // Hangi salonda sunuluyor
        public Salon Salon { get; set; }
        public ICollection<Employee> Employees { get; set; } // Hizmeti verebilen çalışanlar
    }
}

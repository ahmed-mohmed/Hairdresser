using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hairdresser_Website.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(1, 1440)] // مدة الخدمة من 1 دقيقة إلى يوم كامل (بالدقائق)
        public int Duration { get; set; } // In minutes

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, 10000)] // سعر الخدمة بين 0.01 و 10,000
        public decimal Price { get; set; }

        // Foreign Key
        [Required]
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}

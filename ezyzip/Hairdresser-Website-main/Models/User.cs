using Hairdresser_Website.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string UserId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    [MaxLength(20)]
    public string Role { get; set; } // "admin", "customer"

    public ICollection<Appointment> Appointments { get; set; }
}

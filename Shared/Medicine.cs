using System.ComponentModel.DataAnnotations;

namespace PharmaPlus.Server.Models
{
    public class Medicine
    {
        [Key]
        public int MedId { get; set; }
        [Required]
        public string? MedName { get; set; }
        [Required]
        public string? MedDescription { get; set; }
        [Required]
        public string? MedType { get; set; }
        [Required]
        public string? Potency { get; set; }
        [Required]
        public DateTime Expiry { get; set; }
    }
}

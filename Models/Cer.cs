using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P360.RSA.ModelsQuery.Models
{
    public class Cer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CerId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public int BeneficaireId { get; set; }
        public int ReferentId { get; set; }
        public string TenantId { get; set; } = null!;

    }
}

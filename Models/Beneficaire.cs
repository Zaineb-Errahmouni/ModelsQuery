using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P360.RSA.ModelsQuery.Models
{
    public class Beneficaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BeneficaireId { get; set; }

        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Ville { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;

    }
}

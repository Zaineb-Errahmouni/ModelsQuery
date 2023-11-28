using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P360.RSA.ModelsQuery.Models
{
    public class Referent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferentId { get; set; }

        public string Name { get; set; } = string.Empty;

    }
}

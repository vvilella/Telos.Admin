using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telos.Admin.Model
{
    [Table("Unidade", Schema = "Telos")]
    public partial class Unidade
    {
        [Key]
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        public string UnidadeCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Endereco { get; set; }

        [Required]
        public long Cep { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}

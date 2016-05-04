using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telos.Admin.Model
{
    [Table("Curso", Schema = "Telos")]
    public partial class Curso
    {
        [Key]
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        public string CursoCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(300)]
        public string Descricao { get; set; }

        public decimal PrecoPadrao { get; set; }

        public int MesesDuracao { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}

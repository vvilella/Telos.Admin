using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Telos.Admin.Model
{
    [Table("Professor", Schema = "Telos")]
    public partial class Professor
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CpfCode { get; set; }
        
        [Required]
        [MaxLength(300)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        public string Email { get; set; }

        [Required]
        public long Telefone { get; set; }

        [Required]
        public long Celular { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Telos.Admin.Model
{
    [Table("Aluno", Schema = "Telos")]
    public partial class Aluno
    {
        [Key]
        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string CpfCode { get; set; }

        [Required]
        [MaxLength(300)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Rg { get; set; }

        [Required]
        [MaxLength(300)]
        public string Endereco { get; set; }

        [Required]
        [MaxLength(9)]
        public string Cep { get; set; }

        [Required]
        public long Telefone { get; set; }

        [Required]
        public long Celular { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}

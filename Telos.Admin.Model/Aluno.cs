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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CpfCode { get; set; }

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
        public long Cep { get; set; }

        [Required]
        public long Telefone { get; set; }

        [Required]
        public long Celular { get; set; }

        public String NomeResponsavel { get; set; }

        public long CpfResponsavel { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}

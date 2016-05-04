using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telos.Admin.Model
{
    [Table("Matricula", Schema = "Telos")]
    public partial class Matricula
    {
        [Key]
        [Required]
        [MaxLength(11)]
        [MinLength(1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 MatriculaCode { get; set; }

        public Unidade Unidade { get; set; }

        public Aluno Aluno { get; set; }

        public Professor Professor { get; set; }

        public Curso Curso { get; set; }

        public decimal ValorMensalidade { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public Int32 DiaVencimento { get; set; }

        public StatusMatricula Status { get; set; }

        public DiaSemana DiaCurso { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}

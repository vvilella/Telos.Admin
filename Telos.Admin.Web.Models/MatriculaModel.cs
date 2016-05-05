using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telos.Admin.Model;

namespace Telos.Admin.Web.Models
{
    public class MatriculaModel
    {
        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        [Display(Name = "MatriculaModel_MatriculaCode", ResourceType = typeof(AppResources))]
        public long MatriculaCode { get; set; }

        [Display(Name = "MatriculaModel_Unidade", ResourceType = typeof(AppResources))]
        public Unidade Unidade { get; set; }

        [Display(Name = "MatriculaModel_Aluno", ResourceType = typeof(AppResources))]
        public Aluno Aluno { get; set; }

        [Display(Name = "MatriculaModel_Professor", ResourceType = typeof(AppResources))]
        public Professor Professor { get; set; }

        [Display(Name = "MatriculaModel_Curso", ResourceType = typeof(AppResources))]
        public Curso Curso { get; set; }

        [Display(Name = "MatriculaModel_ValorMensalidade", ResourceType = typeof(AppResources))]
        public decimal ValorMensalidade { get; set; }

        [Display(Name = "MatriculaModel_DataInicio", ResourceType = typeof(AppResources))]
        public DateTime DataInicio { get; set; }

        [Display(Name = "MatriculaModel_DataTermino", ResourceType = typeof(AppResources))]
        public DateTime DataTermino { get; set; }
        
        [Display(Name = "MatriculaModel_DiaVencimento", ResourceType = typeof(AppResources))]
        public Int32 DiaVencimento { get; set; }

        [Display(Name = "MatriculaModel_Status", ResourceType = typeof(AppResources))]
        public StatusMatricula Status { get; set; }

        [Display(Name = "MatriculaModel_DiaCurso", ResourceType = typeof(AppResources))]
        public DiaSemana DiaCurso { get; set; }

        [Display(Name = "MatriculaModel_ModifiedDate", ResourceType = typeof(AppResources))]
        public DateTime ModifiedDate { get; set; }
    }
}

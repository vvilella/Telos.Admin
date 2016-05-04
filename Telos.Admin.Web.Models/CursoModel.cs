using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telos.Admin.Web.Models
{
    public class CursoModel
    {
        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [Display(Name = "CursoModel_CursoCode", ResourceType = typeof(AppResources))]
        public string CursoCode { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "CursoModel_Nome", ResourceType = typeof(AppResources))]
        public string Nome { get; set; }

        [MaxLength(300)]
        [Display(Name = "CursoModel_Descricao", ResourceType = typeof(AppResources))]
        public string Descricao { get; set; }

        [Display(Name = "CursoModel_PrecoPadrao", ResourceType = typeof(AppResources))]
        public decimal PrecoPadrao { get; set; }

        [Display(Name = "CursoModel_MesesDuracao", ResourceType = typeof(AppResources))]
        public int MesesDuracao { get; set; }

        [Display(Name = "CursoModel_ModifiedDate", ResourceType = typeof(AppResources))]
        public DateTime ModifiedDate { get; set; }
    }
}

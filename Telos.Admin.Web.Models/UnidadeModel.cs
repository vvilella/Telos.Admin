using System;
using System.ComponentModel.DataAnnotations;

namespace Telos.Admin.Web.Models
{
    public class UnidadeModel
    {
        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        [Display(Name = "UnidadeModel_UnidadeCode", ResourceType = typeof(AppResources))]
        public string UnidadeCode { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "UnidadeModel_Nome", ResourceType = typeof(AppResources))]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "UnidadeModel_Endereco", ResourceType = typeof(AppResources))]
        public string Endereco { get; set; }

        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        [Display(Name = "UnidadeModel_Cep", ResourceType = typeof(AppResources))]
        public long Cep { get; set; }

        [Display(Name = "UnidadeModel_ModifiedDate", ResourceType = typeof(AppResources))]
        public DateTime ModifiedDate { get; set; }
    }
}


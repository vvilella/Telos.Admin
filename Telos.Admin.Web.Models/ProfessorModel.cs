using System;
using System.ComponentModel.DataAnnotations;

namespace Telos.Admin.Web.Models
{
    public class ProfessorModel
    {
        [Required]
        [Display(Name = "ProfessorModel_CpfCode", ResourceType = typeof(AppResources))]
        public long CpfCode { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "ProfessorModel_Nome", ResourceType = typeof(AppResources))]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "ProfessorModel_Email", ResourceType = typeof(AppResources))]
        public string Email { get; set; }

        [Required]
        [Display(Name = "ProfessorModel_Telefone", ResourceType = typeof(AppResources))]
        public long Telefone { get; set; }

        [Required]
        [Display(Name = "ProfessorModel_Celular", ResourceType = typeof(AppResources))]
        public long Celular { get; set; }

        [Display(Name = "ProfessorModel_DataNascimento", ResourceType = typeof(AppResources))]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "ProfessorModel_ModifiedDate", ResourceType = typeof(AppResources))]
        public DateTime ModifiedDate { get; set; }

    }
}

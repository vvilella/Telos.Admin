using System;
using System.ComponentModel.DataAnnotations;

namespace Telos.Admin.Web.Models
{
    public class AlunoModel
    {
        [Required]
        [Display(Name = "AlunoModel_CpfCode", ResourceType = typeof(AppResources))]
        public long CpfCode { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "AlunoModel_Nome", ResourceType = typeof(AppResources))]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "AlunoModel_Email", ResourceType = typeof(AppResources))]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "AlunoModel_Rg", ResourceType = typeof(AppResources))]
        public string Rg { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "AlunoModel_Endereco", ResourceType = typeof(AppResources))]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "AlunoModel_Cep", ResourceType = typeof(AppResources))]
        public long Cep { get; set; }

        [Required]
        [Display(Name = "AlunoModel_Telefone", ResourceType = typeof(AppResources))]
        public long Telefone { get; set; }

        [Required]
        [Display(Name = "AlunoModel_Celular", ResourceType = typeof(AppResources))]
        public long Celular { get; set; }

        [Display(Name = "AlunoModel_DataNascimento", ResourceType = typeof(AppResources))]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "AlunoModel_ModifiedDate", ResourceType = typeof(AppResources))]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "AlunoModel_NomeReponsavel", ResourceType = typeof(AppResources))]
        public String NomeResponsavel { get; set; }

        [Display(Name = "AlunoModel_CpfResponsavel", ResourceType = typeof(AppResources))]
        public long CpfResponsavel { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Preecnha o campo nome")]
        [MaxLength(150, ErrorMessage = "O campo nome deve ter no maximo 150 caracters")]
        [MinLength(2, ErrorMessage = "O campo nome deve ter no maximo 2 caracters")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preecnha o campo E-mail")]
        [MaxLength(150, ErrorMessage = "O campo Sobrenome deve ter no maximo 150 caracters")]
        [MinLength(2, ErrorMessage = "O campo Sobrenome deve ter no maximo 2 caracters")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preecnha o campo Sobrenome")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracters")]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
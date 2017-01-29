using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Preecnha o campo nome")]
        [MaxLength(150, ErrorMessage = "O campo nome deve ter no maximo 150 caracters")]
        [MinLength(2, ErrorMessage = "O campo nome deve ter no maximo 2 caracters")]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        [Required(ErrorMessage = "Preecnha o campo Valor")]
        public decimal Valor { get; set; }
        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
        public int ClienteID { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
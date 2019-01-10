using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [MaxLength(30, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        [DisplayName("Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "SobreNome é Obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        [DisplayName("SobreNome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email é Obrigatório")]
        [MaxLength(255, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Campo deve ser um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime InsertAt { get; set; }

        [DisplayName("Ativo?")]
        public bool Actived { get; set; }


        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}
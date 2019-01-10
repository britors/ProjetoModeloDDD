using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [MaxLength(255, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(10, ErrorMessage = "Minimo de {0} caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Valor é Obrigatório")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999")]
        [DisplayName("Valor")]
        public decimal Price { get; set; }

        [DisplayName("Disponivel?")]
        public bool Actived { get; set; }

        public int CustomerId { get; set; }

       public virtual CustomerViewModel Customer { get; set; }
    }
}
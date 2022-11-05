using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesTop.Models
{
    [Table("tb_Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage = "O tamanho máximo é 100 caracteres!")]
        [Required(ErrorMessage = "Informe o nome da categoria!")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres!")]
        [Required(ErrorMessage = "Informe a descrição da categoria!")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
        //define relacionamento um para muitos entre categoria e lanches (uma categoria pode ter vários lanches, uma lista de lanches)
        public List<Lanche> Lanches { get; set; }
    }
}

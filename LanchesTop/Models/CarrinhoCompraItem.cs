using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesTop.Models
{
    [Table("tb_CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        [Key]
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}

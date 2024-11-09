using System.ComponentModel.DataAnnotations.Schema;

namespace Cart.Domain.Entidades
{
    public class ItemCarrinho
    {
        public long Id { get; set; }
        public long CarrinhoID { get; set; }
        public long ProdutoID { get; set; }
        public long Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        [ForeignKey("CarrinhoID")]
        public Carrinho Carrinho { get; set; }
    }
}

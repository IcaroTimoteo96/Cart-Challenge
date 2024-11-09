namespace Cart.Models
{
    public class CarrinhoModel
    {
        public long UserID { get; set; }

        public List<ItemCarrinhoModel> Itens { get; set; }
    }
}

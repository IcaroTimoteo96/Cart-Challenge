namespace Cart.Domain.Entidades
{
    public class Carrinho
    {
        public long Id { get; set; }

        public long UserID { get; set; }

        public ICollection<ItemCarrinho> ItensCarrinho { get; set; }
    }
}

namespace Cart.Application.CasosDeUso.Request
{
    public class CarrinhoRequest
    {
        public long UserID { get; set; }

        public List<ItemCarrinhoRequest> Itens { get; set; }
    }
}

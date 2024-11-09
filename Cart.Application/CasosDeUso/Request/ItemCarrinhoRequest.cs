namespace Cart.Application.CasosDeUso.Request
{
    public class ItemCarrinhoRequest
    {
        public long ProdutoID { get; set; }

        public long Quantidade { get; set; }

        public double PrecoUnitario { get; set; }
    }
}

using Cart.Domain.Entidades;

namespace Cart.Application.CasosDeUso.Response
{
    public class BuscarItensResponse
    {
        public long ProdutoID { get; set; }

        public long Quantidade { get; set; }

        public double PrecoUnitario { get; set; }
    }
}

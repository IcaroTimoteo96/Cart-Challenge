using Cart.Domain.Entidades;

namespace Cart.Domain.Interfaces
{
    public interface ICarrinhoRepository
    {
        Carrinho Salvar(Carrinho item);
    }
}

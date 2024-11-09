using Cart.Domain.Entidades;

namespace Cart.Domain.Interfaces
{
    public interface IItemCarrinhoRepository
    {
        void Salvar(ItemCarrinho item);
        void Atualizar(ItemCarrinho item);
        void RemoverItem(ItemCarrinho item);
        ItemCarrinho BuscarItemPorID(long id);
        ItemCarrinho BuscarItemPorProdutoID(long id);
        List<ItemCarrinho> BuscarItens(int carrinhoId);
    }
}

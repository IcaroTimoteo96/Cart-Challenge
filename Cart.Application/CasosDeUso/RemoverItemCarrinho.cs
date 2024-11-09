using Cart.Application.CasosDeUso.Response;
using Cart.Domain.Interfaces;

namespace Cart.Application.CasosDeUso
{
    public class RemoverItemCarrinho
    {
        private readonly IItemCarrinhoRepository _itemCarrinhoRepository;

        public RemoverItemCarrinho(IItemCarrinhoRepository itemCarrinhoRepository)
        {
            _itemCarrinhoRepository = itemCarrinhoRepository;
        }

        public BaseResponse<object> RemoverItem(long itemCarrinhoId)
        {
            var response = new BaseResponse<object>();

            try
            {
                var itemCarrinho = _itemCarrinhoRepository.BuscarItemPorID(itemCarrinhoId);

                if (itemCarrinho != null)
                {
                    _itemCarrinhoRepository.RemoverItem(itemCarrinho);
                }

                response.Success = true;
                response.Message = "O item foi removido do carrinho.";

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Erro ao buscar itens: {ex.Message}";
            }
       
            return response;
        }
    }
}

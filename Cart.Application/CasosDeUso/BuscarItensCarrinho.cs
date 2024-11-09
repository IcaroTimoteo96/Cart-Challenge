using Cart.Application.CasosDeUso.Response;
using Cart.Domain.Entidades;
using Cart.Domain.Interfaces;
using System.Collections.Generic;

namespace Cart.Application.CasosDeUso
{
    public class BuscarItensCarrinho
    {
        private readonly IItemCarrinhoRepository _itemCarrinhoRepository;

        public BuscarItensCarrinho(IItemCarrinhoRepository itemCarrinhoRepository)
        {
            _itemCarrinhoRepository = itemCarrinhoRepository;
        }

        public BaseResponse<List<BuscarItensResponse>> BuscarItens(int carrinhoId)
        {
            var response = new BaseResponse<List<BuscarItensResponse>>();

            try
            {
                var listaItens = _itemCarrinhoRepository.BuscarItens(carrinhoId);

                foreach (var item in listaItens)
                {
                    response.Data = listaItens.Select(item => new BuscarItensResponse
                    {
                        ProdutoID = item.ProdutoID,
                        PrecoUnitario = item.PrecoUnitario, 
                        Quantidade = item.Quantidade
                    }).ToList();
                }
                response.Success = true;
                response.Message = "Busca realizada com sucesso!";
            }
            catch(Exception ex)
            {
                response.Message = $"Erro ao buscar itens: {ex.Message}";
                response.Success = false;
            }

            return response;
        }
    }
}

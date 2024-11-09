using Cart.Application.CasosDeUso;
using Cart.Application.CasosDeUso.Request;
using Cart.Application.CasosDeUso.Response;
using Cart.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrinhoController : ControllerBase
    {
        private readonly AdicionarItemCarrinho _adicionarItemCarrinho;
        private readonly BuscarItensCarrinho _buscarItensCarrinho;
        private readonly RemoverItemCarrinho _removerItemCarrinho;
        public CarrinhoController(AdicionarItemCarrinho adicionarItemCarrinho, 
            BuscarItensCarrinho buscarItensCarrinho, 
            RemoverItemCarrinho removerItemCarrinho)
        {
            _adicionarItemCarrinho = adicionarItemCarrinho;
            _buscarItensCarrinho = buscarItensCarrinho;
            _removerItemCarrinho = removerItemCarrinho;
        }

        [HttpPost]
        [Route("adicionar-item")]
        public IActionResult AdicionarItem(CarrinhoModel item)
        {
            var itens = item.Itens.Select(x => new ItemCarrinhoRequest
            {
                ProdutoID = x.ProdutoID,
                PrecoUnitario = x.PrecoUnitario,
                Quantidade = x.Quantidade
            }).ToList();

            var carrinhoRequest = new CarrinhoRequest
            {
                UserID = item.UserID,
                Itens = itens
            };

            var response = _adicionarItemCarrinho.AdicionarItem(carrinhoRequest);

            return Ok(response);
        }

        [HttpPost]
        [Route("remover-item")]
        public IActionResult RemoverItem(long itemCarrinhoID)
        {
            var response = _removerItemCarrinho.RemoverItem(itemCarrinhoID);
            return Ok(response);
        }

        [HttpGet("buscar-itens")]
        public ActionResult<BaseResponse<List<BuscarItensResponse>>> BuscarItens([FromQuery]int carrinhoId)
        {
            var response = _buscarItensCarrinho.BuscarItens(carrinhoId);
            return Ok(response);
        }
    }
}

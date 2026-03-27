using Microsoft.AspNetCore.Mvc;
using ConfectioneryOrdering.Api.Models;

namespace ConfectioneryOrdering.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private static List<Pedido> pedidos = new List<Pedido>();
        private static int contadorId = 1;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(pedidos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            pedido.Id = contadorId++;
            pedidos.Add(pedido);

            return Ok(pedido);
        }   
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] Pedido pedidoAtualizado)
            {
                var pedido = pedidos.FirstOrDefault(p => p.Id == id);
                if (pedido == null)
                    return NotFound();
                else
                {
                    //ajustar e deixar só status
                    pedido.NomeCliente = pedidoAtualizado.NomeCliente;
                    pedido.Produto = pedidoAtualizado.Produto;
                    pedido.Quantidade = pedidoAtualizado.Quantidade;
                }
                return Ok(pedido);
            }
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var pedido = pedidos.FirstOrDefault(p => p.Id == id);
                if (pedido == null)
                    return NotFound();
                else
                {
                    pedidos.Remove(pedido);
                    return Ok(pedido);
                }
            }
    }
}
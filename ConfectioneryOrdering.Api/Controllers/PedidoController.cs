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
    }
}
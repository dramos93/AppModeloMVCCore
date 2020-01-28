using Microsoft.AspNetCore.Mvc;

namespace DevIo.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        [Route("pedidos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
using DevIO.UI.Modelo.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Modelo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidosRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidosRepository = pedidoRepository;
        }

        //É uma maneira para injetar caso não seja possivel faze-lo via construtor, porém não é recomendado
        //public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        public IActionResult Index()
        {
            var pedido = _pedidosRepository.ObterPedido();

            return View();
        }
    }
}

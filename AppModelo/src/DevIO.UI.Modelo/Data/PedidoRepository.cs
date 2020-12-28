using DevIO.UI.Modelo.Models;

namespace DevIO.UI.Modelo.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }

    }
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}

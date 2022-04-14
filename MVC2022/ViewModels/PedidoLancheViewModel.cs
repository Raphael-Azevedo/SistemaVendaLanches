using MVC2022.Models;

namespace MVC2022.ViewModels
{
    public class PedidoLancheViewModel
    {
        public Pedido Pedido { get; set; }    
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}

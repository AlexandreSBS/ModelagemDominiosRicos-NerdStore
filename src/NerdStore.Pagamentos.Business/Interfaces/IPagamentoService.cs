using NerdStore.Core.DomainObjects.DTO;
using NerdStore.Pagamentos.Business.Entities;
using System.Threading.Tasks;

namespace NerdStore.Pagamentos.Business.Interfaces
{
    public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}

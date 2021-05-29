using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catologo.Domain.Events
{
    public class ProductEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProductEventHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvent messagem, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(messagem.AggregateId);

            // Enviar um email para o setor de compras
        }
    }
}

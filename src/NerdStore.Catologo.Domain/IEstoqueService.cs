using NerdStore.Core.DomainObjects.DTO;
using System;
using System.Threading.Tasks;

namespace NerdStore.Catologo.Domain
{
    public interface IEstoqueService : IDisposable
    {
        /// <summary>
        /// Subtrai itens de um produto ao estoque.
        /// </summary>
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);
        Task<bool> DebitarListaProdutosPedido(ListaProdutosPedido lista);
        /// <summary>
        /// Adiciona itens de um produto ao estoque.
        /// </summary>
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporListaProdutosPedido(ListaProdutosPedido lista);
    }
}

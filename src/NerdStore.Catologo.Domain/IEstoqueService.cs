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
        /// <summary>
        /// Adiciona itens de um produto ao estoque.
        /// </summary>
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
    }
}

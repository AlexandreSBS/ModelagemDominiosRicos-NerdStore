using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catologo.Domain.Events
{
    public class ProdutoAbaixoEstoqueEvent : DomainEvent
    {
        public int QuantidadeRestante { get; private set; }

        public ProdutoAbaixoEstoqueEvent(Guid aggregateId, int quantidadeRestante) : base(aggregateId) => QuantidadeRestante = quantidadeRestante;

    }
}

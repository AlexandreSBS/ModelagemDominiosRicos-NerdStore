using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoTests
    {
        [Fact(DisplayName = "Change")]
        [Trait("Pedido", "CalcularValorTotalDesconto")]
        public void Pedido_CalcularValorTotalDesconto_DeveRetornaErroSeVoucherENulo()
        {
            // Arrange
            var pedido = new Pedido(Guid.NewGuid(), true, 33, 1040);

            // Act & Assert
            Assert.Throws<DomainException>(() => pedido.CalcularValorTotalDesconto());
        }
    }
}

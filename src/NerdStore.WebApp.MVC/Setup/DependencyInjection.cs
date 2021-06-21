using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catologo.Domain;
using NerdStore.Catologo.Domain.Events;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Pagamentos.AntiCorruption;
using NerdStore.Pagamentos.Business.Interfaces;
using NerdStore.Pagamentos.Business.Services;
using NerdStore.Pagamentos.Data;
using NerdStore.Pagamentos.Data.Repository;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Application.Commands.Handlers;
using NerdStore.Vendas.Application.Events;
using NerdStore.Vendas.Application.Events.Handlers;
using NerdStore.Vendas.Application.Queries;
using NerdStore.Vendas.Data.Repository;
using NerdStore.Vendas.Domain;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Vendas 
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoQueries, PedidoQueries>();

            services.AddScoped<INotificationHandler<PedidoRascunhoIniciadoEvent>, PedidoEventHandler>();
            services.AddScoped<INotificationHandler<PedidoAtualizadoEvent>, PedidoEventHandler>();
            services.AddScoped<INotificationHandler<PedidoItemAdicionadoEvent>, PedidoEventHandler>();

            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarItemPedidoCommand, bool>, PedidoCommandHandler>();
            services.AddScoped<IRequestHandler<RemoverItemPedidoCommand, bool>, PedidoCommandHandler>();
            services.AddScoped<IRequestHandler<AplicarVoucherPedidoCommand, bool>, PedidoCommandHandler>();

            // Pagamento
            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
            services.AddScoped<IPayPalGateway, PayPalGateway>();
            services.AddScoped<IConfigurationManager,ConfigurationManager>();
            services.AddScoped<PagamentoContext>();

         //   services.AddScoped<INotificationHandler<PedidoEstoqueConfirmadoEvent>, PagamentoEventHandler>();
        }
    }
}

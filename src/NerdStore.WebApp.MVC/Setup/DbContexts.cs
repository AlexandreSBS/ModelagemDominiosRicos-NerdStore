using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalogo.Data;
using NerdStore.Pagamentos.Data;
using NerdStore.Vendas.Data;
using NerdStore.WebApp.MVC.Data;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DbContexts
    {
        public static void AddNerdStoreDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<CatalogoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<VendasContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<PagamentoContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}

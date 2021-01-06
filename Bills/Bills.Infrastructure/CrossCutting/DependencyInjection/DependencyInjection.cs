using Bills.Application;
using Bills.Domain.Interfaces.Application;
using Bills.Domain.Interfaces.Data.Factory;
using Bills.Domain.Interfaces.Data.Repository;
using Bills.Domain.Interfaces.Services;
using Bills.Infrastructure.Data.Factories;
using Bills.Infrastructure.Data.Repositories;
using Bills.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bills.Infrastructure.CrossCutting.DependencyInjection
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IBillParserApplication, BillParserApplication>();
            services.AddSingleton<IBillFactory, BillFactory>();
            services.AddSingleton(typeof(IBillParserFactory<>), typeof(BillParserFactory<>));
            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<ISupplyFormatRepository, SupplyFormatRepository>();
            services.AddScoped<IBillFormatService, BillFormatService>();
            services.AddScoped<IBillParserService, BillParserService>();
        }
    }
}

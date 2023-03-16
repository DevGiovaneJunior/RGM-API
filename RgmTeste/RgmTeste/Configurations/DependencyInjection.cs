using AutoMapper;
using RgmTeste.Domain.Interfaces;
using RgmTeste.Domain.Mappers;
using RgmTeste.Domain.Services;
using RgmTeste.Infra.Interfaces;
using RgmTeste.Infra.Repositories;

namespace RgmTeste.Api.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRequiredDependencies(this IServiceCollection services)
        {

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToDtoMapper());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}

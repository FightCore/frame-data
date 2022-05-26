using FightCore.Repositories;
using FightCore.Services;

namespace FightCore.Api.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<ICharacterService, CharacterService>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddScoped<ICharacterRepository, CharacterRepository>();
        }
    }
}

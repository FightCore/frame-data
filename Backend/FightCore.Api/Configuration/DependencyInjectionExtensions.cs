using FightCore.Repositories;
using FightCore.Services;

namespace FightCore.Api.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<ICharacterService, CharacterService>()
                .AddScoped<IMoveService, MoveService>()
                .AddScoped<IHitboxService, HitboxService>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddScoped<ICharacterRepository, CharacterRepository>()
                .AddScoped<IMoveRepository, MoveRepository>()
                .AddScoped<IHitboxRepository, HitboxRepository>();
        }
    }
}

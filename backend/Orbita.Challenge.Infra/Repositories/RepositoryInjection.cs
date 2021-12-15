using Microsoft.Extensions.DependencyInjection;
using Orbita.Challenge.Infra.Interface;

namespace Orbita.Challenge.Infra.Repositories
{
    public class RepositoryInjection
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IRepositoryStudent, RepositoryStudent>();
        }
    }
}
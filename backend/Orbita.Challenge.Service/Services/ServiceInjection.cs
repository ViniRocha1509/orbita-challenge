using Microsoft.Extensions.DependencyInjection;
using Orbita.Challenge.Service.Interfaces;

namespace Orbita.Challenge.Service.Services
{
    public class ServiceInjection
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
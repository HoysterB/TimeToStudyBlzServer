using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TimeToStudy.Data.Context;
using TimeToStudy.Data.Implementations;
using TimeToStudy.Data.Repository;
using TimeToStudy.Domain.Interfaces;
using TimeToStudy.Domain.Repository;

namespace TimeToStudy.IoC.DependencyInjection
{
    public static class ConfigurationRepository
    {
        public static void ConfigureDependenciesService(IServiceCollection service)
        {
            service.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            service.AddScoped<IEstudanteRepository, EstudanteImplementation>();
            service.AddScoped<IMateriaRepository, MateriaImplementation>();

            service.AddDbContext<TimeToStudyContext>(
                   opt => opt.UseSqlServer(
                       "Server=localhost\\SQLEXPRESS;Database=TimeToStudy; Trusted_connection = true")
                   );
        }
    }
}

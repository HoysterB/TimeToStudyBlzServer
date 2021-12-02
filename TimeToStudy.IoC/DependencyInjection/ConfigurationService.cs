using Microsoft.Extensions.DependencyInjection;
using TimeToStudy.Domain.Interfaces.Services.Estudante;
using TimeToStudy.Domain.Interfaces.Services.Materia;
using TimeToStudy.Service.Services;

namespace TimeToStudy.IoC.DependencyInjection
{
    public static class ConfigurationService
    {
        public static void ConfigureDependenciesService(IServiceCollection service)
        {
            service.AddTransient<IEstudanteService, EstudanteService>();
            service.AddTransient<IMateriaService, MateriaService>();
        }
    }
}

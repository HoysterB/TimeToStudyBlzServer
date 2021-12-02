using TimeToStudy.Domain.Entities;
using TimeToStudy.Domain.Interfaces;

namespace TimeToStudy.Domain.Repository
{
    public interface IEstudanteRepository : IRepository<Estudante>
    {
        object Logar(string email, string senha);
        Task<Estudante> CriarMateria(Estudante entity);
        List<Materia> PegarMaterias(Estudante entity);
    }
}

using _Est = TimeToStudy.Domain.Entities;

namespace TimeToStudy.Domain.Interfaces.Services.Estudante
{
    public interface IEstudanteService
    {
        Task<_Est.Estudante> SelectByIdAsync(Guid id);
        Task<IEnumerable<_Est.Estudante>> SelectAsync();
        Task<_Est.Estudante> InsertAsync(_Est.Estudante entity);
        Task<_Est.Estudante> UpdateAsync(_Est.Estudante entity);
        Task<_Est.Estudante> CriarMateria(_Est.Estudante entity);
        Task<bool> DeleteAsync(int id);
        List<_Est.Materia> GetMateriaList(_Est.Estudante entity);
        object GetByLogin(string email, string senha);
    }
}

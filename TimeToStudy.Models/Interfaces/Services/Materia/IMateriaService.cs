using _Mat = TimeToStudy.Domain.Entities;

namespace TimeToStudy.Domain.Interfaces.Services.Materia
{
    public interface IMateriaService
    {
        Task<_Mat.Materia> SelectByIdAsync(Guid id);
        Task<IEnumerable<_Mat.Materia>> SelectAsync();
        Task<_Mat.Materia> InsertAsync(_Mat.Materia entity);
        Task<_Mat.Materia> UpdateAsync(_Mat.Materia entity);
        Task<bool> DeleteAsync(int id);
    }
}

using TimeToStudy.Domain.Entities;
using TimeToStudy.Domain.Interfaces;
using TimeToStudy.Domain.Interfaces.Services.Materia;

namespace TimeToStudy.Service.Services
{
    public class MateriaService : IMateriaService
    {
        private IRepository<Materia> _repo;
        public MateriaService(IRepository<Materia> repo)
        {
            _repo = repo;
        }
        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Materia> InsertAsync(Materia entity) => _repo.InsertAsync(entity);

        public Task<IEnumerable<Materia>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Materia> SelectByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Materia> UpdateAsync(Materia entity)
        {
            throw new NotImplementedException();
        }
    }
}

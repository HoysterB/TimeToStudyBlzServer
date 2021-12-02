using Microsoft.EntityFrameworkCore;
using TimeToStudy.Data.Context;
using TimeToStudy.Data.Repository;
using TimeToStudy.Domain.Entities;
using TimeToStudy.Domain.Repository;

namespace TimeToStudy.Data.Implementations
{
    public class MateriaImplementation : BaseRepository<Materia>, IMateriaRepository
    {
        private DbSet<Estudante> _dataSet;

        public MateriaImplementation(TimeToStudyContext context) : base(context)
        {
            _dataSet = context.Set<Estudante>();
        }
    }
}

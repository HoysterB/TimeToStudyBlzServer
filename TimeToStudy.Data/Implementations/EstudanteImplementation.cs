using Microsoft.EntityFrameworkCore;
using TimeToStudy.Data.Context;
using TimeToStudy.Data.Repository;
using TimeToStudy.Domain.Entities;
using TimeToStudy.Domain.Repository;

namespace TimeToStudy.Data.Implementations
{
    public class EstudanteImplementation : BaseRepository<Estudante>, IEstudanteRepository
    {
        private DbSet<Estudante> _dataSet;
        public EstudanteImplementation(TimeToStudyContext context) : base(context)
        {
            _dataSet = context.Set<Estudante>();
        }

        public async Task<Estudante> CriarMateria(Estudante entity)
        {
            throw new NotImplementedException();
        }

        public object Logar(string email, string senha)
        {
            try
            {

                if (!Exists(email))
                {
                    return new
                    {
                        Mensagem = "Erro ao logar"
                    };
                }

                var estudante = _dataSet.FirstOrDefault(x => x.Email == email && x.Senha == senha);

                if (estudante == null)
                {
                    return new
                    {
                        Mensagem = "Erro ao logar"
                    };
                }

                return estudante;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Materia> PegarMaterias(Estudante entity)
        {
            try
            {
                var materias = entity.Materias.ToList();
                return materias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Exists(string email)
        {
            var estudante = _dataSet.FirstOrDefault(x => x.Email == email);

            return estudante != null ? true : false;
        }
    }
}

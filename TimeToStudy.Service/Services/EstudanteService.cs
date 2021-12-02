using System.Net;
using System.Net.Mail;
using System.Text;
using TimeToStudy.Domain.Entities;
using TimeToStudy.Domain.Interfaces;
using TimeToStudy.Domain.Interfaces.Services.Estudante;
using TimeToStudy.Domain.Repository;

namespace TimeToStudy.Service.Services
{
    public class EstudanteService : IEstudanteService
    {
        private IRepository<Estudante> _repo;
        private IEstudanteRepository _estudante;
        public EstudanteService(IRepository<Estudante> repo, IEstudanteRepository estudante)
        {
            _repo = repo;
            _estudante = estudante;
        }
        public async Task<Estudante> CriarMateria(Estudante entity) => await _estudante.CriarMateria(entity);

        public async Task<bool> DeleteAsync(int id) => await _repo.DeleteAsync(id);

        public object GetByLogin(string email, string senha) => _estudante.Logar(email, senha);

        public List<Materia> GetMateriaList(Estudante entity) => _estudante.PegarMaterias(entity);

        public async Task<Estudante> InsertAsync(Estudante entity)
        {
            try
            {
                await _repo.InsertAsync(entity);

                EmailService.EnviarEmail(entity.Email, entity.Nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public async Task<IEnumerable<Estudante>> SelectAsync() => await _repo.SelectAsync();

        public async Task<Estudante> SelectByIdAsync(Guid id) => await SelectByIdAsync(id);

        public async Task<Estudante> UpdateAsync(Estudante entity) => await UpdateAsync(entity);
    }
}

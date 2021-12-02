namespace TimeToStudy.Domain.Entities
{
    public class Estudante : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual List<SessaoDeEstudo> SessoesDeEstudos { get; set; }
        public virtual List<Materia> Materias { get; set; }
    }
}

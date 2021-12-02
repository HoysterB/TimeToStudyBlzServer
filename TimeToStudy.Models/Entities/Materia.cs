namespace TimeToStudy.Domain.Entities
{
    public class Materia : BaseEntity
    {
        public string Nome { get; set; }
        public int ConteudoId { get; set; }
        public Conteudo Conteudos { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
    }
}

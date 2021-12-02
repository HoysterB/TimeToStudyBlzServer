namespace TimeToStudy.Domain.Entities
{
    public class AgendaDeEstudo : BaseEntity
    {
        public DateTime Data { get; set; }
        public int SessaoDeEstudoId { get; set; }
        public SessaoDeEstudo SessaoDeEstudo { get; set; }
    }
}

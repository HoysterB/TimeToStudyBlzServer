namespace TimeToStudy.Domain.Entities
{
    public class SessaoDeEstudo : BaseEntity
    {
        public int AtividadesRealizadas { get; set; }
        public int AtividadesCorretas { get; set; }
        public string TempoDuracao { get; set; }
        public int EstudanteId { get; set; }
        public Estudante Estudante { get; set; }
        public int AgendaDeEstudoId { get; set; }
        public AgendaDeEstudo AgendaDeEstudo { get; set; }
    }
}

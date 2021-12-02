namespace TimeToStudy.Domain.Entities
{
    public class Revisao : BaseEntity
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
    }
}

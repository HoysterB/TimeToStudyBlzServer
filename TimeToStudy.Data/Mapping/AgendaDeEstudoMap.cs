using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Mapping
{
    public class AgendaDeEstudoMap : BaseDomainMap<AgendaDeEstudo>
    {
        public AgendaDeEstudoMap() : base("tb_agendaDeEstudo") { }
        public override void Configure(EntityTypeBuilder<AgendaDeEstudo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Data).IsRequired();

            builder.HasOne(x => x.SessaoDeEstudo).WithOne(x => x.AgendaDeEstudo).HasForeignKey<SessaoDeEstudo>(x => x.AgendaDeEstudoId);
        }
    }
}
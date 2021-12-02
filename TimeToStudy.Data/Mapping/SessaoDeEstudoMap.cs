using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Mapping
{
    public class SessaoDeEstudoMap : BaseDomainMap<SessaoDeEstudo>
    {
        public SessaoDeEstudoMap() : base("tb_sessaoDeEstudo") { }

        public override void Configure(EntityTypeBuilder<SessaoDeEstudo> builder)
        {
            builder.Property(x => x.AtividadesRealizadas)
                .HasColumnName("atividadesRealizadas");

            builder.Property(x => x.AtividadesCorretas)
                .HasColumnName("atividadesCorretas");

            builder.Property(x => x.TempoDuracao)
                .HasColumnName("tempoDuracao")
                .HasMaxLength(100);

            builder.HasOne(x => x.Estudante)
                   .WithMany(x => x.SessoesDeEstudos)
                   .HasForeignKey(x => x.EstudanteId);

            builder.HasOne(x => x.AgendaDeEstudo).WithOne(x => x.SessaoDeEstudo)
                .HasForeignKey<AgendaDeEstudo>(x => x.SessaoDeEstudoId)
                .OnDelete(DeleteBehavior.Restrict);
                

        }
    }
}

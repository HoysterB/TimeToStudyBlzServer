using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Mapping
{
    public class EstudanteMap : BaseDomainMap<Estudante>
    {
        public EstudanteMap() : base("tb_estudante") { }
        public override void Configure(EntityTypeBuilder<Estudante> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Sobrenome).HasColumnName("sobrenome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Senha).HasColumnName("senha").HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Materias).WithOne(x => x.Estudante).HasForeignKey(x => x.EstudanteId);
        }
    }
}

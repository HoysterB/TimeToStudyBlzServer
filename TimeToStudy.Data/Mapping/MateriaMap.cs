using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Mapping
{
    public class MateriaMap : BaseDomainMap<Materia>
    {
        public MateriaMap() : base("tb_materia") { }
        public override void Configure(EntityTypeBuilder<Materia> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.Estudante).WithMany(x => x.Materias).HasForeignKey(x => x.EstudanteId);

            builder.HasOne(x => x.Conteudos).WithOne().HasForeignKey<Materia>(X => X.ConteudoId);
        }
    }
}

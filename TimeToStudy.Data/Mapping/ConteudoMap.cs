using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Mapping
{
    public class ConteudoMap : BaseDomainMap<Conteudo>
    {
        public ConteudoMap() : base("tb_conteudo"){ }

        public override void Configure(EntityTypeBuilder<Conteudo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("escricao").HasMaxLength(100).IsRequired();

            
        }

    }
}

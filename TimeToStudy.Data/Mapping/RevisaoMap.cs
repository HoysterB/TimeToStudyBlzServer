using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Mapping
{
    public class RevisaoMap : BaseDomainMap<Revisao>
    {
        public RevisaoMap() : base("tb_revisao"){ }

        public override void Configure(EntityTypeBuilder<Revisao> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(100).IsRequired(); 
        }
    }
}

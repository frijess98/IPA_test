using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCE.ServicingPartnerInfoCheck.Contracts.Types;

namespace SCE.ServicingPartnerInfoCheck.DAL.Configurations
{
    /// <summary>
    /// DbContext Configuration
    /// </summary>
    public class SpInfoCheckConfiguration : IEntityTypeConfiguration<ServicingPartnerInfoCheckEntity>
    {
        public void Configure(EntityTypeBuilder<ServicingPartnerInfoCheckEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("SpInfoCheckEntities");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataServices.Configurations;
public class PlantMap : IEntityTypeConfiguration<Plant>
{
    public void Configure(EntityTypeBuilder<Plant> e) {
        e.HasKey(x => x.Guid);
        e.HasAlternateKey(x => x.PlantCode);
        e.Property(x => x.PlantCode).HasColumnName("plant_code").HasComputedColumnSql("CONCAT(RegionId, '.', Id)", true);
        e.Property(x => x.Name).IsRequired();
        e.Property(x => x.MaxAltitude).HasPrecision(10, 2);
        e.Property(x => x.MinAltitude).HasPrecision(10, 2);
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Region).WithMany(x => x.Plants).HasForeignKey(x => x.RegionId);

    }
}
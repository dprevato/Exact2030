using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataServices.Configurations;
public class ChartMap : IEntityTypeConfiguration<Chart>
{
    public void Configure(EntityTypeBuilder<Chart> e) {
        e.ToTable("chart");
        e.HasKey(x => x.Id);
        e.Property(x => x.Title).IsRequired();
        e.Property(x => x.ShowLegend).HasDefaultValue(false);
        e.Property(x => x.Author).IsRequired().HasDefaultValueSql("PUBLIC");
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.ChartCollection).WithMany(x => x.Charts).HasForeignKey(x => x.ChartCollectionId);
        e.HasMany(x => x.YAxis).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
        e.HasMany(x => x.Curves).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
        e.HasMany(x => x.Annotations).WithOne(x => x.Chart).HasForeignKey(x => x.ChartId);
    }
}
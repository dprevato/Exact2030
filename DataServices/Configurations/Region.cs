using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataServices.Configurations;
public class RegionMap : IEntityTypeConfiguration<Model.Region>
{
    public void Configure(EntityTypeBuilder<Model.Region> e) {
        e.HasKey(x => x.Guid);
        e.Property(x => x.Id).HasMaxLength(1); // Secondo la codifica, consente 30 zone differenti. Più che sufficienti a meno di richieste specifiche
        e.Property(x => x.Version).IsRowVersion();
    }
}
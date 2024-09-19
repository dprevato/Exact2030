using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataServices.Configurations;
public class FormulaMap : IEntityTypeConfiguration<Formula>
{
    public void Configure(EntityTypeBuilder<Formula> e) {
        e.HasKey(x => x.Id);
        e.Property(x => x.Version).IsRowVersion();
    }
}
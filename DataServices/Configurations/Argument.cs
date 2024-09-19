using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataServices.Configurations;
public class ArgumentMap : IEntityTypeConfiguration<Argument>
{
    public void Configure(EntityTypeBuilder<Argument> e) {
        e.ToTable("argument");
        e.HasKey(x => new { x.PmId, x.ArgPos });
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Pm).WithMany(x => x.FormulaArguments).HasForeignKey(x => x.PmId);
    }
}
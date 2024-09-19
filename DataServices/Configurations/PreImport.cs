using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataServices.Configurations;
public class PreImportMap : IEntityTypeConfiguration<PreImport>
{
    public void Configure(EntityTypeBuilder<PreImport> e) {
        e.HasKey(x => new { x.PmCode, x.ScanDateTime });
    }
}
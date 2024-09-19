using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataServices.Configurations;
public class ChartNoteMap : IEntityTypeConfiguration<ChartNote>
{
    public void Configure(EntityTypeBuilder<ChartNote> e) {
        e.ToTable("chart_note");
        e.HasKey(x => x.Id);
        e.Property(x => x.Id).ValueGeneratedNever();
        e.Property(x => x.XPos).IsRequired(false);
        e.Property(x => x.YPos).IsRequired(false);
        e.Property(x => x.NoteColor).IsRequired(false);
        e.Property(x => x.NoteText).IsRequired(false);
        e.Property(x => x.NoteAlignment).IsRequired(false).HasConversion<string>();
        e.Property(x => x.Version).IsRowVersion();

        e.HasOne(x => x.Chart).WithMany(x => x.Annotations).HasForeignKey(x => x.ChartId);
        e.HasOne(x => x.YAxis).WithMany(x => x.Annotations).HasForeignKey(x => x.YAxisId);
    }
}
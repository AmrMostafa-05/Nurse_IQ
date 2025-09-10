using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class DiplomaConfiguration : IEntityTypeConfiguration<Diploma>
    {
        public void Configure(EntityTypeBuilder<Diploma> builder)
        {
            builder.HasKey(d=>d.ID);

            builder.Property(x => x.Title)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(150).IsRequired();

            builder.Property(l => l.Description)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(x => x.Duration)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100).IsRequired();

            builder.HasOne(u => u.CreatedBy)
                    .WithMany(c => c.Diplomas)
                    .HasForeignKey(c => c.CreatedByAdminId);


            builder.HasData(SeedData.Diplomas);

        }
    }
}

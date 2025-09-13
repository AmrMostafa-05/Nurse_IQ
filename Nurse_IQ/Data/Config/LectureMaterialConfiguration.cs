using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class LectureMaterialConfiguration : IEntityTypeConfiguration<LectureMaterial>
    {
        public void Configure(EntityTypeBuilder<LectureMaterial> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(l => l.FileName)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(200).IsRequired();

            builder.Property(l => l.FileUrl)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(255).IsRequired();

            builder.HasOne(m => m.lecture)
                   .WithMany(l => l.Materials)
                   .HasForeignKey(m => m.LectureId);



            //builder.HasData(SeedData.LectureMaterials);
        }
    }
}

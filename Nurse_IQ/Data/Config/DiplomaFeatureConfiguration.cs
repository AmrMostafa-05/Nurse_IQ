using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class DiplomaFeatureConfiguration : IEntityTypeConfiguration<DiplomaFeature>
    {
        public void Configure(EntityTypeBuilder<DiplomaFeature> builder)
        {
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Title)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(150).IsRequired();

            builder.Property(l => l.Description)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(x => x.Icon)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200).IsRequired();

            builder.HasOne(f => f.Diploma)
             .WithMany(d => d.features)
             .HasForeignKey(f => f.DiplomaId);


            //builder.HasData(SeedData.DiplomaFeatures);

        }
    }
}

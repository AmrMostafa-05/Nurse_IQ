using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class Trainings_videosConfiguration : IEntityTypeConfiguration<training_video>
    {
        public void Configure(EntityTypeBuilder<training_video> builder)
        {
            builder.HasKey(tv => tv.Id);

            builder.Property(tv => tv.Title)
               .HasColumnType("VARCHAR")
               .HasMaxLength(200).IsRequired();

            builder.Property(tv => tv.Description)
                   .HasColumnType("nvarchar(max)");

            builder.Property(tv => tv.category)
               .HasColumnType("VARCHAR")
               .HasMaxLength(200).IsRequired();

            builder.Property(tv => tv.publishedDate)
               .HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();

            builder.Property(tv => tv.duration)
             .HasColumnType("VARCHAR")
             .HasMaxLength(100).IsRequired();


            builder.Property(tv => tv.thumbnailUrl)
               .HasColumnType("VARCHAR")
               .HasMaxLength(255).IsRequired();

            builder.Property(tv => tv.instructorName)
                   .HasMaxLength(150);

            builder.Property(tv => tv.instructorImage)
                   .HasMaxLength(500);

            builder.Property(tv => tv.videoUrl)
                   .HasMaxLength(500);

            builder.Property(tv => tv.numberOfViews)
                   .HasDefaultValue(0);

            builder.HasOne(u => u.CreatedBy)
           .WithMany(c => c.TrainingVideos)
           .HasForeignKey(c => c.CreatedByAdminId);



           builder.HasData(SeedData.TrainingVideos);

        }

    }
}

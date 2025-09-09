using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Enums;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100).IsRequired();

            builder.Property(x => x.Title)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100).IsRequired();

            builder.Property(x => x.YearLevel)////handling the enum to be stored as string in the database
              .HasConversion<string>()
              .IsRequired();

            builder.Property(x => x.courseType)
            .HasConversion<string>()
            .IsRequired();

            builder.Property(x => x.semister)
            .HasConversion<string>()
            .IsRequired();

            builder.Property(x => x.Duration)
               .HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();

            builder.Property(x => x.imageUrl)
               .HasColumnType("VARCHAR")
               .HasMaxLength(255).IsRequired();


            builder.Property(l => l.smallDescription)
               .HasColumnType("VARCHAR")
               .HasMaxLength(255).IsRequired();

            builder.Property(l => l.bigDescription)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(x => x.courseTopics)
                   .IsRequired();

            builder.Property(x => x.courseRequizetes)
                   .IsRequired(false);




            builder.HasOne(u => u.User)
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.UserId);

            builder.HasOne(u => u.AddedBy)
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.AdminId);

        }
    }
}

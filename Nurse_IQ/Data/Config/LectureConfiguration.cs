using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class LectureConfiguration : IEntityTypeConfiguration<Lecture>
    {

        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Title)
               .HasColumnType("VARCHAR")
               .HasMaxLength(200).IsRequired();


            builder.Property(l => l.smallDescription)
               .HasColumnType("VARCHAR")
               .HasMaxLength(255).IsRequired();

            builder.Property(l => l.bigDescription)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(l => l.duration)
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(55).IsRequired();

            builder.Property(l => l.videoUrl)
                       .IsRequired();

            builder.HasOne(l => l.Course)
                       .WithMany(c => c.Lectures)
                       .HasForeignKey(l => l.CourseId);

            builder.HasOne(l => l.User)
                       .WithMany(u => u.Lectures)
                       .HasForeignKey(l => l.UserId);

            builder.HasOne(u => u.AddedBy)
                       .WithMany(c => c.Lectures)
                       .HasForeignKey(c => c.AdminId);
        }
    }
}

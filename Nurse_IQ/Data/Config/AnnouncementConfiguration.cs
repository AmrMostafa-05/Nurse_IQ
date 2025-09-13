using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Title)
                 .HasColumnType("VARCHAR")
                 .HasMaxLength(150).IsRequired();

            builder.Property(a => a.Content)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(255).IsRequired();

            builder.Property(a => a.Date)
                 .HasColumnType("datetime")
                 .IsRequired();

            builder.Property(a => a.category)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(150).IsRequired();

            builder.Property(a => a.AdminImageUrl)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(255).IsRequired();


            builder.HasOne(a => a.CreatedBy)
                   .WithMany(u => u.Announcements)
                   .HasForeignKey(a => a.CreatedByAdminId);

           // builder.HasData(SeedData.Announcements);

        }
    }
}

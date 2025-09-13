using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class TrainingConfiguration : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100).IsRequired();

            builder.Property(q => q.HospitalName)
             .HasColumnType("VARCHAR")
             .HasMaxLength(100).IsRequired();

            builder.Property(t => t.Location)
             .HasColumnType("VARCHAR")
             .HasMaxLength(100).IsRequired();

            builder.Property(t => t.Category)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100).IsRequired();

            builder.Property(t => t.salary)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

            builder.Property(t => t.Experience)
                   .HasMaxLength(200);

            builder.Property(l => l.Description)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(t => t.imageUrl)
       .HasMaxLength(500);

            builder.Property(t => t.postedDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(t => t.deadline)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(c => c.requirement)
                 .HasConversion(ValueConverters.StringListConverter)
                 .Metadata.SetValueComparer(ValueConverters.StringListComparer);



            builder.HasOne(t => t.CreatedBy)
                .WithMany(qz => qz.Trainings)
                .HasForeignKey(q => q.CreatedByAdminId);
            
            
            //builder.HasData(SeedData.Trainings);

        }
    }
}

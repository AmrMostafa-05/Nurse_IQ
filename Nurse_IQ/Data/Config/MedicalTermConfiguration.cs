using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class MedicalTermConfiguration : IEntityTypeConfiguration<MedicalTerm>
    {
        public void Configure(EntityTypeBuilder<MedicalTerm> builder)
        {
            builder.HasKey(mt => mt.Id);

            builder.Property(mt => mt.arabicName)
               .HasColumnType("VARCHAR")
               .HasMaxLength(55).IsRequired();


            builder.Property(mt => mt.englishName)
               .HasColumnType("VARCHAR")
               .HasMaxLength(55).IsRequired();


            builder.Property(mt => mt.latinName)
               .HasColumnType("VARCHAR")
               .HasMaxLength(55).IsRequired();

            builder.Property(mt => mt.category)
                  .HasColumnType("VARCHAR")
               .HasMaxLength(55).IsRequired();

            builder.Property(mt => mt.example)
                   .HasColumnType("nvarchar(max)");

            builder.Property(mt =>mt.synonyms)
                   .IsRequired(false);

            builder.HasOne(u => u.User)
                .WithMany(c => c.medicalTerms)
                .HasForeignKey(c => c.UserId);

            builder.HasOne(u => u.AddedBy)
                .WithMany(c => c.medicalTerms)
                .HasForeignKey(c => c.AdminId);
        }
    }
}

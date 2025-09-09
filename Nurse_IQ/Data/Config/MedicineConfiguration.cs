using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class MedicineConfiguration: IEntityTypeConfiguration<Medicine>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Medicine> builder)
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

            builder.Property(mt => mt.form)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100).IsRequired();

            builder.Property(mt => mt.description)
                  .HasColumnType("VARCHAR")
               .HasMaxLength(500).IsRequired();

            builder.Property(mt => mt.indications)
                  .HasColumnType("VARCHAR")
               .HasMaxLength(500).IsRequired();

            builder.Property(mt => mt.sideEffects)
                  .HasColumnType("VARCHAR")
               .HasMaxLength(500).IsRequired();


            builder.Property(mt => mt.dosage)
                  .HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();


            builder.HasOne(u => u.User)
                .WithMany(c => c.medicines)
                .HasForeignKey(c => c.UserId);

            


        }
    }
}

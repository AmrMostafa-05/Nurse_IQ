using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class ContactFormConfiguration:IEntityTypeConfiguration<ContactForm>
    {
        

        public void Configure(EntityTypeBuilder<ContactForm> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.FullName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150).IsRequired();

            builder.Property(x => x.phone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.InquiryType)
            .HasConversion<string>()
            .IsRequired();

            builder.Property(l => l.message)
                   .HasColumnType("nvarchar(max)").IsRequired();


            builder.HasOne(a => a.CreatedBy)
                   .WithMany(u => u.ContactForms)
                   .HasForeignKey(a => a.CreatedByAdminId);

            //builder.HasData(SeedData.ContactForms);

        }
    }
}

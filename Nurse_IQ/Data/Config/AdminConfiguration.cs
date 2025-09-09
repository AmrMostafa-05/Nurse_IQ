using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {

        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(x => x.Email)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(150).IsRequired();

            builder.Property(x => x.Password)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(150).IsRequired();

        }


    }
}

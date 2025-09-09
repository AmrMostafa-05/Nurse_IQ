using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.ID);

            builder.Property(x => x.Fname)
               .HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();

            builder.Property(x => x.Lname)
               .HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();

            builder.Property(u => u.FullName)
                 .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");


            builder.Property(x => x.gender)
                      .HasConversion<string>()
                      .IsRequired();

            builder.Property(x => x.email)
               .HasColumnType("VARCHAR")
               .HasMaxLength(100).IsRequired();

            builder.Property(x => x.password)
               .HasColumnType("VARCHAR")
               .HasMaxLength(150).IsRequired();

            builder.Property(x => x.phone)
               .HasColumnType("VARCHAR")
               .HasMaxLength(50).IsRequired();

            builder.Property(x => x.role)
                   .HasConversion<string>()
                   .IsRequired();

            builder.Property(x => x.Year_Level)
                 .HasConversion<string>()
                 .IsRequired(false);// in case he isn't student

            builder.Property(x => x.Educational_institution)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150).IsRequired();

            builder.Property(x => x.Type_of_Educational_institution)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(u => u.BirthDate)
                   .IsRequired(); 




        }
    }
}

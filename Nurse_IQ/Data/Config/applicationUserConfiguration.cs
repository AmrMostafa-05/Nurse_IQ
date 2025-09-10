using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Enums.User;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class applicationUserConfiguration : IEntityTypeConfiguration<applicationUser>
    {
        public void Configure(EntityTypeBuilder<applicationUser> builder)
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

            //the config for email and password and phone also configuration exists in userIdentity table we can override on it but not best pracitce

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




            var hasher = new PasswordHasher<applicationUser>();

            builder.HasData(SeedData.Users);



        }
    }
}

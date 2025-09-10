using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{

    public class UserRegisteredTrainingsConfiguration : IEntityTypeConfiguration<UserRegisteredTraining>
    {
        public void Configure(EntityTypeBuilder<UserRegisteredTraining> builder)
        {
            // the user here represent the role of student
            builder.HasKey(a => new { a.UserId, a.TrainingId }); // composite PK


            builder.HasOne(ut => ut.User)
                .WithMany(u => u.UserRegisteredTrainings)
                .HasForeignKey(ut => ut.UserId);

            builder.HasOne(ut => ut.Training)
                   .WithMany(t => t.UserRegisteredTrainings)
                   .HasForeignKey(ut => ut.TrainingId);


            builder.HasData(SeedData.UserRegisteredTrainings);

        }
    }
}

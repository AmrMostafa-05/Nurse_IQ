using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{

    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(x => x.Title)
               .HasColumnType("VARCHAR")
               .HasMaxLength(150).IsRequired();


            builder.HasOne(q => q.Course)
                   .WithMany(c => c.Quizzes)
                   .HasForeignKey(q => q.CourseId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(q => q.Lecture)
                   .WithOne(l => l.Quiz)
                   .HasForeignKey<Quiz>(e => e.LectureId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.HasIndex(x => x.LectureId);//to inforce the 1 to 1 relation


            builder.HasOne(u => u.User)
                .WithMany(c => c.quizes)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);


           //builder.HasData(SeedData.Quizzes);

        }
    }
}

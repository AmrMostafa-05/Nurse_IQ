using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Text)
             .HasColumnType("VARCHAR")
             .HasMaxLength(250).IsRequired();

            builder.Property(x => x.hardnessType)////handling the enum to be stored as string in the database
              .HasConversion<string>()
              .IsRequired();

            builder.Property(q => q.CorrectAnswer)
              .HasColumnType("VARCHAR")
              .HasMaxLength(250).IsRequired();


            builder.Property(q => q.Student_Answer)//not required cuz he can let the quistion no answered
              .HasColumnType("VARCHAR")
              .HasMaxLength(250);

            builder.Property(q=>q.options)
                   .IsRequired(false);//cuz it can be مقالي

            builder.HasOne(q => q.Quiz)
                   .WithMany(qz => qz.Questions)
                   .HasForeignKey(q => q.QuizId);
        }
    }
}

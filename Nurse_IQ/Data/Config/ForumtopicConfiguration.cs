using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class ForumtopicConfiguration : IEntityTypeConfiguration<Forumtopic>
    {
        public void Configure(EntityTypeBuilder<Forumtopic> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
               .HasColumnType("VARCHAR")
               .HasMaxLength(200).IsRequired();

            builder.Property(t => t.Description)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(t => t.category)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(200).IsRequired();

            builder.Property(c => c.comments)
                    .HasConversion(ValueConverters.StringListConverter)
                    .Metadata.SetValueComparer(ValueConverters.StringListComparer);
            //


            builder.HasOne(u => u.User)
                .WithMany(c => c.forumtopics)
                .HasForeignKey(c => c.UserId);

           // builder.HasData(SeedData.Forumtopics);


        }
    }
}

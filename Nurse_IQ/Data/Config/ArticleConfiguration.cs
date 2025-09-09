using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100).IsRequired();

            builder.Property(l => l.Description)
                   .HasColumnType("nvarchar(max)").IsRequired();

            builder.Property(x => x.category)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100).IsRequired();

            builder.Property(x => x.imageUrl)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200).IsRequired();

            builder.Property(x => x.autorImage)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200).IsRequired();

            builder.Property(x => x.publisheDate)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired(); 

            builder.Property(x => x.readTime)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();


            builder.HasOne(l => l.User)
           .WithMany(u => u.articles)
           .HasForeignKey(l => l.UserId);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data.Config
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(150).IsRequired();

            builder.Property(x => x.SubTitle)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100).IsRequired();

            builder.Property(x => x.category)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(100).IsRequired();

            builder.Property(l => l.Description)
                   .HasColumnType("nvarchar(max)").IsRequired();


            builder.Property(o => o.OriginalPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(o => o.discountPercentage)
                   .IsRequired();
            // Computed Columns in SQL
            builder.Property(o => o.DiscountPrice)
                   .HasComputedColumnSql("[OriginalPrice] * [DiscountPercentage] / 100", stored: true);

            builder.Property(o => o.LastPrice)
                   .HasComputedColumnSql("[OriginalPrice] - ([OriginalPrice] * [DiscountPercentage] / 100)", stored: true);

            builder.Property(x => x.imageUrl)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(250).IsRequired();



            builder.HasOne(a => a.CreatedBy)
                   .WithMany(u => u.Offers)
                   .HasForeignKey(a => a.CreatedByAdminId);



            builder.HasData(SeedData.Offers);

        }
    }
}

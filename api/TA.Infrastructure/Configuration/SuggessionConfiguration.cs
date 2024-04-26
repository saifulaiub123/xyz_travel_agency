using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TA.Domain.DBModel;

namespace TA.Infrastructure.Configuration
{
    public class SuggessionConfiguration : IEntityTypeConfiguration<Suggession>
    {
        public void Configure(EntityTypeBuilder<Suggession> builder)
        {
            builder.HasIndex(x => x.CreatedBy)
               .IsUnique(false);
            builder.HasIndex(x => x.UpdatedBy)
               .IsUnique(false);


            builder.Property(x => x.TripDestination)
                .HasMaxLength(250);
            builder.Property(x => x.PlaceToVisit)
                .HasMaxLength(250);
            builder.Property(x => x.AccomodationSuggession)
                .HasMaxLength(250);
            builder.Property(x => x.TravelType)
                .HasMaxLength(50);
            builder.Property(x => x.Dining)
                .HasMaxLength(250);
            builder.Property(x => x.AverageMoneySpent)
                .HasMaxLength(250);
            builder.Property(x => x.Comments)
                .HasMaxLength(250);

            //builder.HasOne(x => x.CreatedByUser)
            //   .WithOne(y => y.CreatedBySuggession)
            //   .HasForeignKey<Suggession>(z => z.CreatedBy)
            //   .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(x => x.UpdatedByUser)
            //   .WithOne(y => y.UpdatedBySuggession)
            //   .HasForeignKey<Suggession>(z => z.UpdatedBy)
            //   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
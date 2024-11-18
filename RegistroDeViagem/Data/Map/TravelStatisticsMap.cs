using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class TravelStatisticsMap : IEntityTypeConfiguration<TravelStatistics>
    {
        public void Configure(EntityTypeBuilder<TravelStatistics> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TotalTrips).IsRequired();
            builder.Property(x => x.TotalVisitedLocations).IsRequired();
            builder.Property(x => x.TotalPhotos).IsRequired();

            builder.HasOne(x => x.User)
                   .WithOne(x => x.TravelStatistics)
                   .HasForeignKey<TravelStatistics>(x => x.UserId)
                   .IsRequired();
        }
    }
}

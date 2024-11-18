using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class ItineraryMap : IEntityTypeConfiguration<Itinerary>
    {
        public void Configure(EntityTypeBuilder<Itinerary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DepartureLocation).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Destination).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DepartureDateTime).IsRequired();
            builder.Property(x => x.ArrivalDateTime).IsRequired();

            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.Itineraries)
                   .HasForeignKey(x => x.TripId)
                   .IsRequired();
        }
    }
}

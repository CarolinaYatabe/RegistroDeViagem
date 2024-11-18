using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class TravelCompanionsMap : IEntityTypeConfiguration<TravelCompanions>
    {
        public void Configure(EntityTypeBuilder<TravelCompanions> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Relation).IsRequired().HasMaxLength(15);

            builder.HasMany(x => x.Trips)
                   .WithMany(x => x.TravelCompanions)
                   .UsingEntity<TripTravelCompanions>(
                    l => l.HasOne<Trip>(e => e.Trip)
                           .WithMany(e => e.TripTravelCompanions)
                           .HasForeignKey(e => e.TripId),
                    r => r.HasOne<TravelCompanions>(e => e.TravelCompanion)
                          .WithMany(e => e.TripTravelCompanions)
                          .HasForeignKey(e => e.TravelCompanionId)
                    );
        }
    }
}

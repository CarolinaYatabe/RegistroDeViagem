using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class TripMap : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Destination).IsRequired().HasMaxLength(40);
            builder.Property(x => x.TripName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.TripStartDate).IsRequired();
            builder.Property(x => x.TripEndDate).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(60);

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Trips)
                   .HasForeignKey(x => x.UserId)
                   .IsRequired();

            builder.HasOne(x => x.Album)
                    .WithOne(x => x.Trip)
                    .HasForeignKey<Album>(x => x.TripId);

            builder.HasMany(x => x.TravelExpenses)
                   .WithOne(x => x.Trip)
                   .HasForeignKey(x => x.TripId);

            builder.HasMany(x => x.Itineraries)
                   .WithOne(x => x.Trip)
                   .HasForeignKey(x => x.TripId);

            builder.HasMany(x => x.Ratings)
                    .WithOne(x => x.Trip)
                    .HasForeignKey(x => x.TripId);
        }
    }
}

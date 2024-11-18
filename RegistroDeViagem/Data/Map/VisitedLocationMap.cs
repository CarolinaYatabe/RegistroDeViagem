using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class VisitedLocationMap : IEntityTypeConfiguration<VisitedLocation>
    {
        public void Configure(EntityTypeBuilder<VisitedLocation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LocationName).IsRequired().HasMaxLength(80);
            builder.Property(x => x.LocationDescription).IsRequired().HasMaxLength(60);
            builder.Property(x => x.VisitDate).IsRequired();

            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.VisitedLocations)
                   .HasForeignKey(x => x.TripId);
        }
    }
}

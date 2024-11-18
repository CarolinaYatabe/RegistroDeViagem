using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class AlbumMap : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(30);
            builder.Property(x => x.CreationDate).IsRequired();

            builder.HasOne(x => x.Trip)
                   .WithOne(x => x.Album)
                   .HasForeignKey<Album>(x => x.TripId);
        }
    }
}

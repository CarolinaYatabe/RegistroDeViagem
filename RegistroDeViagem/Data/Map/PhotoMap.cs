using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class PhotoMap : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(10);
            builder.Property(x => x.Description).HasMaxLength(30);
            builder.Property(x => x.UploadDate).IsRequired();

            builder.HasOne(x => x.Trip)
                   .WithMany()
                   .HasForeignKey(x => x.TripId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Album)
                   .WithMany(x => x.Photos)
                   .HasForeignKey(x => x.AlbumId);
        }
    }
}

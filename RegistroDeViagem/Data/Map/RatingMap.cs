using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class RatingMap : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Evaluation).IsRequired();
            builder.Property(x => x.Comment).IsRequired().HasMaxLength(30);

            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.Ratings)
                   .HasForeignKey(x => x.TripId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(15);

            builder.HasOne(x => x.TravelStatistics)
                   .WithOne()
                   .HasForeignKey<TravelStatistics>(x => x.UserId);
        }
    }
}

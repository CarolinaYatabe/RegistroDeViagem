using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data.Map
{
    public class TravelExpenseMap : IEntityTypeConfiguration<TravelExpense>
    {
        public void Configure(EntityTypeBuilder<TravelExpense> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ExpenseName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(x => x.ExpenseDate).IsRequired();
            builder.Property(x => x.Category).IsRequired().HasMaxLength(15);

            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.TravelExpenses)
                   .HasForeignKey(x => x.TripId)
                   .IsRequired();
        }
    }
}

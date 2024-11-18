using Microsoft.EntityFrameworkCore;
using RegistroDeViagem.Data.Map;
using RegistroDeViagem.Entities;

namespace RegistroDeViagem.Data
{
    public class RegistroDeViagemContext : DbContext
    {
        public RegistroDeViagemContext(DbContextOptions<RegistroDeViagemContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<VisitedLocation> VisitedLocations { get; set; }
        public DbSet<TravelStatistics> TravelStatistics { get; set; }
        public DbSet<TravelExpense> TravelExpenses { get; set; }
        public DbSet<TravelCompanions> TravelCompanions { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Itinerary> Itinerary { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<TripTravelCompanions> TripTravelCompanions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TripMap());
            modelBuilder.ApplyConfiguration(new VisitedLocationMap());
            modelBuilder.ApplyConfiguration(new TravelStatisticsMap());
            modelBuilder.ApplyConfiguration(new TravelExpenseMap());
            modelBuilder.ApplyConfiguration(new TravelCompanionsMap());
            modelBuilder.ApplyConfiguration(new RatingMap());
            modelBuilder.ApplyConfiguration(new PhotoMap());
            modelBuilder.ApplyConfiguration(new ItineraryMap());
            modelBuilder.ApplyConfiguration(new AlbumMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

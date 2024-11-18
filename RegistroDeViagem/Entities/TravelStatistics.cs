namespace RegistroDeViagem.Entities
{
    public class TravelStatistics: Entity<int>
    {
        public int UserId { get; set; }
        public int TotalTrips { get; set; }
        public int TotalVisitedLocations { get; set; }
        public int TotalPhotos { get; set; }

        public User User { get; set; }
    }
}

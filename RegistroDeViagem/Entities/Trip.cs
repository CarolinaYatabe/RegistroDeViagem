namespace RegistroDeViagem.Entities
{
    public class Trip : Entity<int>
    {
        public int UserId { get; set; }
        public string Destination { get; set; }
        public string TripName { get; set; }
        public DateTime TripStartDate { get; set; }
        public DateTime TripEndDate { get; set; }
        public string Description { get; set; }

        public ICollection<VisitedLocation> VisitedLocations { get; set; }
        public ICollection<TravelCompanions> TravelCompanions { get; set; }
        public ICollection<TripTravelCompanions> TripTravelCompanions { get; set; }
        public ICollection<Itinerary> Itineraries { get; set; }
        public ICollection<TravelExpense> TravelExpenses { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public Album Album { get; set; }
        public User User { get; set; }
    }
}

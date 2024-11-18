namespace RegistroDeViagem.Entities
{
    public class TravelCompanions : Entity<int>
    {
        public string Name { get; set; }
        public string Relation {  get; set; }
        public ICollection<Trip> Trips { get; set; }
        public ICollection<TripTravelCompanions> TripTravelCompanions { get; set; }
    }
}

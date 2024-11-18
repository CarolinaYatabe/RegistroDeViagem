namespace RegistroDeViagem.Entities
{
    public class Itinerary : Entity<int>
    {
        public int TripId { get; set; }
        public string DepartureLocation { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }

        public Trip Trip { get; set; }
    }
}

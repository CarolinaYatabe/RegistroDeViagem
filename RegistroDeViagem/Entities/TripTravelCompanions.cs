namespace RegistroDeViagem.Entities
{
    public class TripTravelCompanions
    {
        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int TravelCompanionId { get; set; }
        public TravelCompanions TravelCompanion { get; set; }
    }
}

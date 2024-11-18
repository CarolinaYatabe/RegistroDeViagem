namespace RegistroDeViagem.Entities
{
    public class VisitedLocation : Entity<int>
    {
        public int TripId { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public DateTime VisitDate { get; set; }
        
        public Trip Trip { get; set; }
    }
}

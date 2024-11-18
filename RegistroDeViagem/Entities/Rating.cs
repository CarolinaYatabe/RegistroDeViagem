namespace RegistroDeViagem.Entities
{
    public class Rating : Entity<int>
    {
        public int TripId { get; set; }
        public int Evaluation { get; set; }
        public string Comment { get; set; }

        public Trip Trip { get; set; }
    }
}

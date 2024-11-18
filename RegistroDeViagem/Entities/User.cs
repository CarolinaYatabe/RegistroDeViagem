namespace RegistroDeViagem.Entities
{
    public class User : Entity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Trip> Trips { get; set; }

        public int TravelStatisticsId { get; set; }
        public TravelStatistics TravelStatistics { get; set; }
    }
}

namespace RegistroDeViagem.Entities
{
    public class Album : Entity<int>
    {
        public int TripId { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }

        public  ICollection<Photo> Photos { get; set; }
        public Trip Trip { get; set; }
    }
}

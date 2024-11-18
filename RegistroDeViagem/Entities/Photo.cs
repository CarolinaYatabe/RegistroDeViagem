namespace RegistroDeViagem.Entities
{
    public class Photo : Entity<int>
    {
        public int TripId { get; set; }
        public int AlbumId { get; set; }
        public string ImageUrl { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime UploadDate { get; set; }

        public Trip Trip { get; set; }
        public Album Album { get; set; }
    }
}

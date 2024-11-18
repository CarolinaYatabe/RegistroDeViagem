namespace RegistroDeViagem.Entities
{
    public class TravelExpense: Entity<int>
    {
        public int TripId { get; set; }
        public string ExpenseName { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }

        public Trip Trip { get; set; }
    }
}

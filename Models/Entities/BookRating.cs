namespace BookStore.Models.Entities
{
    public class BookRating
    {
        public Guid Id { get; set; }
        public string BookId { get; set; }
        public string Review { get; set; }
        public string Remarks { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }   
    }
}

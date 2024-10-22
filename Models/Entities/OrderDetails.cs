namespace BookStore.Models.Entities
{
    public class OrderDetails
    {
        public Guid Id { get; set; }    
        public string UserId { get; set; }
        public string BookId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
